﻿namespace Slyce.Common.Controls.Diagramming.Shapes
{
    partial class ShapeCanvas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ShapeCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Name = "ShapeCanvas";
            this.Size = new System.Drawing.Size(770, 446);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShapeCanvas_MouseDoubleClick);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShapeCanvas_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.SizeChanged += new System.EventHandler(this.Canvas_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShapeCanvas_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
