﻿// Written by A.Darkins
// Date 13/8/2020
// Issue : Initial
//
// child form with unique title
//



namespace Exercise_2___MDI
{
    partial class ChildForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int _FormID;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
     
         // constructor taking 1 param which is a unique integer to be added to the title   
        public ChildForm(int formID)
        {
            _FormID = formID;
            this.Text = "New Form " + _FormID.ToString();
        }

        public int FormID
        {
            get { return _FormID; }
        }




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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ChildForm";
        }

        #endregion
    }
}