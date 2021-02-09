
namespace ArcadeGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.countdown = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Black;
            this.StartButton.CausesValidation = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(291, 216);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(216, 81);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Play Game";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // countdown
            // 
            this.countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.Color.White;
            this.countdown.Location = new System.Drawing.Point(370, 238);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(60, 43);
            this.countdown.TabIndex = 3;
            this.countdown.Text = "3";
            this.countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdown.Visible = false;
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.Transparent;
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.ForeColor = System.Drawing.Color.White;
            this.go.Location = new System.Drawing.Point(359, 216);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(90, 78);
            this.go.TabIndex = 4;
            this.go.Text = "GO!";
            this.go.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.go.Visible = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(846, 557);
            this.Controls.Add(this.go);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Label go;
    }
}

