namespace LocationTracker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mapToDisplay = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // mapToDisplay
            // 
            this.mapToDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapToDisplay.Bearing = 0F;
            this.mapToDisplay.CanDragMap = true;
            this.mapToDisplay.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapToDisplay.GrayScaleMode = false;
            this.mapToDisplay.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapToDisplay.LevelsKeepInMemmory = 5;
            this.mapToDisplay.Location = new System.Drawing.Point(1, 0);
            this.mapToDisplay.MarkersEnabled = true;
            this.mapToDisplay.MaxZoom = 2;
            this.mapToDisplay.MinZoom = 2;
            this.mapToDisplay.MouseWheelZoomEnabled = true;
            this.mapToDisplay.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapToDisplay.Name = "mapToDisplay";
            this.mapToDisplay.NegativeMode = false;
            this.mapToDisplay.PolygonsEnabled = true;
            this.mapToDisplay.RetryLoadTile = 0;
            this.mapToDisplay.RoutesEnabled = true;
            this.mapToDisplay.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapToDisplay.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapToDisplay.ShowTileGridLines = false;
            this.mapToDisplay.Size = new System.Drawing.Size(799, 452);
            this.mapToDisplay.TabIndex = 0;
            this.mapToDisplay.Zoom = 0D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mapToDisplay);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapToDisplay;
    }
}

