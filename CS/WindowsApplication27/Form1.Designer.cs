namespace WindowsApplication27 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spellChecker1
            // 
            this.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = true;
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("en-US");
            this.spellChecker1.ParentContainer = this;
            this.spellChecker1.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.EditValue = "wronly speled txt, but some words are correct :)";
            this.memoEdit1.Location = new System.Drawing.Point(0, 0);
            this.memoEdit1.Name = "memoEdit1";
            this.spellChecker1.SetShowSpellCheckMenu(this.memoEdit1, true);
            this.memoEdit1.Size = new System.Drawing.Size(411, 140);
            this.spellChecker1.SetSpellCheckerOptions(this.memoEdit1, optionsSpelling1);
            this.memoEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 140);
            this.Controls.Add(this.memoEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}

