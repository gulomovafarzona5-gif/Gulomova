using System.Drawing;
using System.Windows.Forms;
using Gulomova.FolderforModel; // пространство имён папки с моделью

namespace Gulomova
{
    // Плитка: показывает одну запись таблицы Table_Motorbike
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        // Заполняет элемент данными из экземпляра класса Table_Motorbike
        public void Fill(Table_Motorbike Motorbike)
        {
            Visible = Motorbike != null;
            if (Motorbike == null)
                return;

            labelIDData.Text = Motorbike.ID.ToString();
            labelModelData.Text = Motorbike.Model;
            labelBrandData.Text = Motorbike.Brand;
            labelPriceData.Text = Motorbike.Price.ToString();
            labelHorsepowerData.Text = Motorbike.Horsepower.ToString();
            labelMileageData.Text = Motorbike.Mileage.ToString();

            // освобождаем предыдущую картинку и не блокируем файл
            if (pictureBoxMotorbike.Image != null)
            {
                pictureBoxMotorbike.Image.Dispose();
                pictureBoxMotorbike.Image = null;
            }

            string path = System.IO.Path.Combine(Application.StartupPath, "Pictures", Motorbike.Picture ?? "");
            if (System.IO.File.Exists(path))
            {
                using (var src = Image.FromFile(path))
                    pictureBoxMotorbike.Image = new Bitmap(src);
            }
        }
    }
}
