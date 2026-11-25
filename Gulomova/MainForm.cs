using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Gulomova.FolderforModel;

namespace Gulomova
{
    public partial class MainForm : Form
    {
        // глобальная статическая переменная для работы с классом ModelDB
        public static ModelDB DB = new ModelDB();

        // все записи таблицы Table_Motorbike
        private List<Table_Motorbike> allMotorbikes = new List<Table_Motorbike>();

        // список, который сейчас показывается (после применения фильтров)
        private List<Table_Motorbike> Motorbikes = new List<Table_Motorbike>();

        // номер записи, показанной в первой плитке
        private int AccNumber = 0;

        private const string AllBrands = "(все)";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            allMotorbikes = DB.Table_Motorbike.ToList();

            comboBoxBrand.Items.Add(AllBrands);
            foreach (string brand in allMotorbikes.Select(m => m.Brand).Where(b => b != null).Distinct().OrderBy(b => b))
                comboBoxBrand.Items.Add(brand);
            comboBoxBrand.SelectedIndex = 0;

            ApplyFilter();
        }

        // Заполняет плитки данными, начиная с записи AccNumber
        private void Loading()
        {
            userControl1.Fill(AccNumber < Motorbikes.Count ? Motorbikes[AccNumber] : null);
            userControl2.Fill(AccNumber + 1 < Motorbikes.Count ? Motorbikes[AccNumber + 1] : null);

            buttonLeft.Enabled = AccNumber > 0;
            buttonRight.Enabled = Motorbikes.Count > AccNumber + 2;
            labelCount.Text = $"Найдено: {Motorbikes.Count}";
        }

        // Перегрузка: Incr == true — листать вправо, false — влево
        private void Loading(bool Incr)
        {
            if (Incr && Motorbikes.Count > AccNumber + 2)
                AccNumber++;
            else if (!Incr && 0 <= AccNumber - 1)
                AccNumber--;
            else
                return;

            Loading();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Loading(true);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        // ---------- Дополнительное задание: фильтрация ----------

        private static double? ParseNumber(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return null;
            text = text.Trim().Replace(',', '.');
            double v;
            return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out v) ? (double?)v : null;
        }

        private void ApplyFilter()
        {
            string model = textBoxModel.Text.Trim();
            string brand = comboBoxBrand.SelectedItem as string;
            double? priceFrom = ParseNumber(textBoxPriceFrom.Text);
            double? priceTo = ParseNumber(textBoxPriceTo.Text);
            double? hpFrom = ParseNumber(textBoxHpFrom.Text);
            double? hpTo = ParseNumber(textBoxHpTo.Text);
            double? mileFrom = ParseNumber(textBoxMileageFrom.Text);
            double? mileTo = ParseNumber(textBoxMileageTo.Text);

            IEnumerable<Table_Motorbike> q = allMotorbikes;

            if (model.Length > 0)
                q = q.Where(m => m.Model != null && m.Model.IndexOf(model, StringComparison.OrdinalIgnoreCase) >= 0);
            if (!string.IsNullOrEmpty(brand) && brand != AllBrands)
                q = q.Where(m => m.Brand == brand);
            if (priceFrom.HasValue) q = q.Where(m => m.Price >= priceFrom);
            if (priceTo.HasValue) q = q.Where(m => m.Price <= priceTo);
            if (hpFrom.HasValue) q = q.Where(m => m.Horsepower >= hpFrom);
            if (hpTo.HasValue) q = q.Where(m => m.Horsepower <= hpTo);
            if (mileFrom.HasValue) q = q.Where(m => m.Mileage >= mileFrom);
            if (mileTo.HasValue) q = q.Where(m => m.Mileage <= mileTo);

            Motorbikes = q.ToList();
            AccNumber = 0;
            Loading();
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxModel.Clear();
            textBoxPriceFrom.Clear();
            textBoxPriceTo.Clear();
            textBoxHpFrom.Clear();
            textBoxHpTo.Clear();
            textBoxMileageFrom.Clear();
            textBoxMileageTo.Clear();
            comboBoxBrand.SelectedIndex = 0; // вызовет ApplyFilter
            ApplyFilter();
        }
    }
}
