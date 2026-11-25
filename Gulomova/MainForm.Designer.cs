namespace Gulomova
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.userControl1 = new Gulomova.UserControl1();
            this.userControl2 = new Gulomova.UserControl1();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.labelFModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelFBrand = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.labelFPrice = new System.Windows.Forms.Label();
            this.textBoxPriceFrom = new System.Windows.Forms.TextBox();
            this.textBoxPriceTo = new System.Windows.Forms.TextBox();
            this.labelFHp = new System.Windows.Forms.Label();
            this.textBoxHpFrom = new System.Windows.Forms.TextBox();
            this.textBoxHpTo = new System.Windows.Forms.TextBox();
            this.labelFMileage = new System.Windows.Forms.Label();
            this.textBoxMileageFrom = new System.Windows.Forms.TextBox();
            this.textBoxMileageTo = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            //
            // panelFilter
            //
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1000, 90);
            this.panelFilter.Controls.Add(this.labelFModel);
            this.panelFilter.Controls.Add(this.textBoxModel);
            this.panelFilter.Controls.Add(this.labelFBrand);
            this.panelFilter.Controls.Add(this.comboBoxBrand);
            this.panelFilter.Controls.Add(this.labelFPrice);
            this.panelFilter.Controls.Add(this.textBoxPriceFrom);
            this.panelFilter.Controls.Add(this.textBoxPriceTo);
            this.panelFilter.Controls.Add(this.labelFHp);
            this.panelFilter.Controls.Add(this.textBoxHpFrom);
            this.panelFilter.Controls.Add(this.textBoxHpTo);
            this.panelFilter.Controls.Add(this.labelFMileage);
            this.panelFilter.Controls.Add(this.textBoxMileageFrom);
            this.panelFilter.Controls.Add(this.textBoxMileageTo);
            this.panelFilter.Controls.Add(this.buttonReset);
            this.panelFilter.Controls.Add(this.labelCount);
            //
            // labelFModel
            //
            this.labelFModel.AutoSize = true;
            this.labelFModel.Location = new System.Drawing.Point(20, 12);
            this.labelFModel.Name = "labelFModel";
            this.labelFModel.Text = "Модель";
            //
            // textBoxModel
            //
            this.textBoxModel.Location = new System.Drawing.Point(20, 30);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(150, 20);
            this.textBoxModel.TextChanged += new System.EventHandler(this.Filter_Changed);
            //
            // labelFBrand
            //
            this.labelFBrand.AutoSize = true;
            this.labelFBrand.Location = new System.Drawing.Point(190, 12);
            this.labelFBrand.Name = "labelFBrand";
            this.labelFBrand.Text = "Бренд";
            //
            // comboBoxBrand
            //
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.Location = new System.Drawing.Point(190, 30);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(150, 21);
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            //
            // labelFPrice
            //
            this.labelFPrice.AutoSize = true;
            this.labelFPrice.Location = new System.Drawing.Point(360, 12);
            this.labelFPrice.Name = "labelFPrice";
            this.labelFPrice.Text = "Цена (от – до)";
            //
            // textBoxPriceFrom
            //
            this.textBoxPriceFrom.Location = new System.Drawing.Point(360, 30);
            this.textBoxPriceFrom.Name = "textBoxPriceFrom";
            this.textBoxPriceFrom.Size = new System.Drawing.Size(70, 20);
            this.textBoxPriceFrom.TextChanged += new System.EventHandler(this.Filter_Changed);
            //
            // textBoxPriceTo
            //
            this.textBoxPriceTo.Location = new System.Drawing.Point(436, 30);
            this.textBoxPriceTo.Name = "textBoxPriceTo";
            this.textBoxPriceTo.Size = new System.Drawing.Size(70, 20);
            this.textBoxPriceTo.TextChanged += new System.EventHandler(this.Filter_Changed);
            //
            // labelFHp
            //
            this.labelFHp.AutoSize = true;
            this.labelFHp.Location = new System.Drawing.Point(530, 12);
            this.labelFHp.Name = "labelFHp";
            this.labelFHp.Text = "Мощность, л.с. (от – до)";
            //
            // textBoxHpFrom
            //
            this.textBoxHpFrom.Location = new System.Drawing.Point(530, 30);
            this.textBoxHpFrom.Name = "textBoxHpFrom";
            this.textBoxHpFrom.Size = new System.Drawing.Size(70, 20);
            this.textBoxHpFrom.TextChanged += new System.EventHandler(this.Filter_Changed);
            //
            // textBoxHpTo
            //
            this.textBoxHpTo.Location = new System.Drawing.Point(606, 30);
            this.textBoxHpTo.Name = "textBoxHpTo";
            this.textBoxHpTo.Size = new System.Drawing.Size(70, 20);
            this.textBoxHpTo.TextChanged += new System.EventHandler(this.Filter_Changed);
            //
            // labelFMileage
            //
            this.labelFMileage.AutoSize = true;
            this.labelFMileage.Location = new System.Drawing.Point(700, 12);
            this.labelFMileage.Name = "labelFMileage";
            this.labelFMileage.Text = "Пробег (от – до)";
            //
            // textBoxMileageFrom
            //
            this.textBoxMileageFrom.Location = new System.Drawing.Point(700, 30);
            this.textBoxMileageFrom.Name = "textBoxMileageFrom";
            this.textBoxMileageFrom.Size = new System.Drawing.Size(70, 20);
            this.textBoxMileageFrom.TextChanged += new System.EventHandler(this.Filter_Changed);
            //
            // textBoxMileageTo
            //
            this.textBoxMileageTo.Location = new System.Drawing.Point(776, 30);
            this.textBoxMileageTo.Name = "textBoxMileageTo";
            this.textBoxMileageTo.Size = new System.Drawing.Size(70, 20);
            this.textBoxMileageTo.TextChanged += new System.EventHandler(this.Filter_Changed);
            //
            // buttonReset
            //
            this.buttonReset.Location = new System.Drawing.Point(870, 28);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 24);
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            //
            // labelCount
            //
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(20, 62);
            this.labelCount.Name = "labelCount";
            this.labelCount.Text = "Найдено: 0";
            //
            // buttonLeft
            //
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonLeft.Location = new System.Drawing.Point(12, 250);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(60, 200);
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            //
            // buttonRight
            //
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonRight.Location = new System.Drawing.Point(912, 250);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(60, 200);
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            //
            // userControl1
            //
            this.userControl1.Location = new System.Drawing.Point(100, 110);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(360, 425);
            //
            // userControl2
            //
            this.userControl2.Location = new System.Drawing.Point(500, 110);
            this.userControl2.Name = "userControl2";
            this.userControl2.Size = new System.Drawing.Size(360, 425);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.userControl2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gulomova — Motorbikes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private UserControl1 userControl1;
        private UserControl1 userControl2;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label labelFModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelFBrand;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label labelFPrice;
        private System.Windows.Forms.TextBox textBoxPriceFrom;
        private System.Windows.Forms.TextBox textBoxPriceTo;
        private System.Windows.Forms.Label labelFHp;
        private System.Windows.Forms.TextBox textBoxHpFrom;
        private System.Windows.Forms.TextBox textBoxHpTo;
        private System.Windows.Forms.Label labelFMileage;
        private System.Windows.Forms.TextBox textBoxMileageFrom;
        private System.Windows.Forms.TextBox textBoxMileageTo;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelCount;
    }
}
