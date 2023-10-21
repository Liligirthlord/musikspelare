namespace Musikspelare
{
    partial class Musikspelare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musikspelare));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnPrevGenre = new System.Windows.Forms.Button();
            this.btnNextGenre = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.Location = new System.Drawing.Point(240, 120);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 51);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.Location = new System.Drawing.Point(340, 120);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 51);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.BackgroundImage")));
            this.btnPrev.Location = new System.Drawing.Point(140, 120);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 51);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnPrevGenre
            // 
            this.btnPrevGenre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevGenre.BackgroundImage")));
            this.btnPrevGenre.Location = new System.Drawing.Point(140, 238);
            this.btnPrevGenre.Name = "btnPrevGenre";
            this.btnPrevGenre.Size = new System.Drawing.Size(75, 51);
            this.btnPrevGenre.TabIndex = 4;
            this.btnPrevGenre.UseVisualStyleBackColor = true;
            // 
            // btnNextGenre
            // 
            this.btnNextGenre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextGenre.BackgroundImage")));
            this.btnNextGenre.Location = new System.Drawing.Point(340, 238);
            this.btnNextGenre.Name = "btnNextGenre";
            this.btnNextGenre.Size = new System.Drawing.Size(75, 51);
            this.btnNextGenre.TabIndex = 3;
            this.btnNextGenre.UseVisualStyleBackColor = true;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.Location = new System.Drawing.Point(234, 257);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(79, 29);
            this.Genre.TabIndex = 5;
            this.Genre.Text = "label1";
            // 
            // Musikspelare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 344);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.btnPrevGenre);
            this.Controls.Add(this.btnNextGenre);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlay);
            this.Name = "Musikspelare";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnPrevGenre;
        private System.Windows.Forms.Button btnNextGenre;
        private System.Windows.Forms.Label Genre;
    }
}

