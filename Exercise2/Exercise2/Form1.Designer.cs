namespace Exercise2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Polygon = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Eclipse = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Red = new System.Windows.Forms.RadioButton();
            this.Black = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Line);
            this.groupBox1.Controls.Add(this.Polygon);
            this.groupBox1.Controls.Add(this.Circle);
            this.groupBox1.Controls.Add(this.Rectangle);
            this.groupBox1.Controls.Add(this.Eclipse);
            this.groupBox1.Location = new System.Drawing.Point(679, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(7, 66);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(45, 17);
            this.Line.TabIndex = 6;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            // 
            // Polygon
            // 
            this.Polygon.AutoSize = true;
            this.Polygon.Location = new System.Drawing.Point(7, 112);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(63, 17);
            this.Polygon.TabIndex = 5;
            this.Polygon.Text = "Polygon";
            this.Polygon.UseVisualStyleBackColor = true;
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(7, 43);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(51, 17);
            this.Circle.TabIndex = 4;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(7, 89);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(74, 17);
            this.Rectangle.TabIndex = 2;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // Eclipse
            // 
            this.Eclipse.AutoSize = true;
            this.Eclipse.Location = new System.Drawing.Point(7, 20);
            this.Eclipse.Name = "Eclipse";
            this.Eclipse.Size = new System.Drawing.Size(59, 17);
            this.Eclipse.TabIndex = 1;
            this.Eclipse.Text = "Eclipse";
            this.Eclipse.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Blue);
            this.groupBox2.Controls.Add(this.Red);
            this.groupBox2.Controls.Add(this.Black);
            this.groupBox2.Location = new System.Drawing.Point(679, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(7, 66);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(46, 17);
            this.Blue.TabIndex = 2;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(7, 43);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(45, 17);
            this.Red.TabIndex = 1;
            this.Red.TabStop = true;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            // 
            // Black
            // 
            this.Black.AutoSize = true;
            this.Black.Location = new System.Drawing.Point(7, 20);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(52, 17);
            this.Black.TabIndex = 0;
            this.Black.TabStop = true;
            this.Black.Text = "Black";
            this.Black.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Polygon;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.RadioButton Black;
        private System.Windows.Forms.RadioButton Eclipse;
    }
}

