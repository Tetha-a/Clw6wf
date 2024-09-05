namespace Clw6wf
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxAlgebra = new System.Windows.Forms.ListBox();
            this.labelAlgebra = new System.Windows.Forms.Label();
            this.labelGeometry = new System.Windows.Forms.Label();
            this.listBoxGeometry = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxAlgebra
            // 
            this.listBoxAlgebra.FormattingEnabled = true;
            this.listBoxAlgebra.Items.AddRange(new object[] {
            "Решение квадратного уравнения",
            "Упрощение алгебраических выражений"});
            this.listBoxAlgebra.Location = new System.Drawing.Point(27, 90);
            this.listBoxAlgebra.Name = "listBoxAlgebra";
            this.listBoxAlgebra.Size = new System.Drawing.Size(224, 69);
            this.listBoxAlgebra.TabIndex = 1;
            this.listBoxAlgebra.Click += new System.EventHandler(this.listBoxAlgebra_SelectedIndexChanged);
            this.listBoxAlgebra.SelectedIndexChanged += new System.EventHandler(this.listBoxAlgebra_SelectedIndexChanged);
            // 
            // labelAlgebra
            // 
            this.labelAlgebra.AutoSize = true;
            this.labelAlgebra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlgebra.Location = new System.Drawing.Point(67, 67);
            this.labelAlgebra.Name = "labelAlgebra";
            this.labelAlgebra.Size = new System.Drawing.Size(73, 20);
            this.labelAlgebra.TabIndex = 2;
            this.labelAlgebra.Text = "Алгебра";
            // 
            // labelGeometry
            // 
            this.labelGeometry.AutoSize = true;
            this.labelGeometry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGeometry.Location = new System.Drawing.Point(387, 67);
            this.labelGeometry.Name = "labelGeometry";
            this.labelGeometry.Size = new System.Drawing.Size(92, 20);
            this.labelGeometry.TabIndex = 3;
            this.labelGeometry.Text = "Геометрия";
            // 
            // listBoxGeometry
            // 
            this.listBoxGeometry.FormattingEnabled = true;
            this.listBoxGeometry.Items.AddRange(new object[] {
            "Теорема пифагора",
            "Нахождение площади треугольника по формуле Герона",
            "Нахождение площади круга"});
            this.listBoxGeometry.Location = new System.Drawing.Point(354, 90);
            this.listBoxGeometry.Name = "listBoxGeometry";
            this.listBoxGeometry.Size = new System.Drawing.Size(295, 69);
            this.listBoxGeometry.TabIndex = 4;
            this.listBoxGeometry.SelectedIndexChanged += new System.EventHandler(this.listBoxGeometry_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxGeometry);
            this.Controls.Add(this.labelGeometry);
            this.Controls.Add(this.labelAlgebra);
            this.Controls.Add(this.listBoxAlgebra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxAlgebra;
        private System.Windows.Forms.Label labelAlgebra;
        private System.Windows.Forms.Label labelGeometry;
        private System.Windows.Forms.ListBox listBoxGeometry;
    }
}

