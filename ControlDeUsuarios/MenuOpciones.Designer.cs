namespace ControlDeUsuarios
{
    partial class MenuOpciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOpciones));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btn_cerrar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnEscanner = new System.Windows.Forms.Button();
            this.btn_registros = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.lbl_user = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_cerrarSesion = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelContenedor.Controls.Add(this.btn_cerrar);
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelSuperior);
            this.panelContenedor.Location = new System.Drawing.Point(-5, -2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1006, 652);
            this.panelContenedor.TabIndex = 0;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.ActiveImage = null;
            this.btn_cerrar.AllowAnimations = true;
            this.btn_cerrar.AllowBuffering = false;
            this.btn_cerrar.AllowToggling = false;
            this.btn_cerrar.AllowZooming = true;
            this.btn_cerrar.AllowZoomingOnFocus = false;
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.ErrorImage")));
            this.btn_cerrar.FadeWhenInactive = false;
            this.btn_cerrar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.ImageActive = null;
            this.btn_cerrar.ImageLocation = null;
            this.btn_cerrar.ImageMargin = 20;
            this.btn_cerrar.ImageSize = new System.Drawing.Size(22, 22);
            this.btn_cerrar.ImageZoomSize = new System.Drawing.Size(42, 42);
            this.btn_cerrar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.InitialImage")));
            this.btn_cerrar.Location = new System.Drawing.Point(962, 1);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Rotation = 0;
            this.btn_cerrar.ShowActiveImage = true;
            this.btn_cerrar.ShowCursorChanges = true;
            this.btn_cerrar.ShowImageBorders = true;
            this.btn_cerrar.ShowSizeMarkers = false;
            this.btn_cerrar.Size = new System.Drawing.Size(42, 42);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.ToolTipText = "";
            this.btn_cerrar.WaitOnLoad = false;
            this.btn_cerrar.Zoom = 20;
            this.btn_cerrar.ZoomSpeed = 10;
            this.btn_cerrar.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.Silver;
            this.panelFormularios.Controls.Add(this.bunifuPictureBox2);
            this.panelFormularios.Location = new System.Drawing.Point(202, 43);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(801, 616);
            this.panelFormularios.TabIndex = 6;
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMostrador_Paint);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.SteelBlue;
            this.panelSuperior.Controls.Add(this.panelSubMenu);
            this.panelSuperior.Controls.Add(this.lbl_user);
            this.panelSuperior.Controls.Add(this.bunifuPictureBox1);
            this.panelSuperior.Controls.Add(this.btn_cerrarSesion);
            this.panelSuperior.Location = new System.Drawing.Point(0, -1);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(202, 653);
            this.panelSuperior.TabIndex = 4;
            this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperior_Paint);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelSubMenu.Controls.Add(this.btnAbout);
            this.panelSubMenu.Controls.Add(this.btnEscanner);
            this.panelSubMenu.Controls.Add(this.btn_registros);
            this.panelSubMenu.Controls.Add(this.btn_usuarios);
            this.panelSubMenu.Location = new System.Drawing.Point(3, 258);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(199, 161);
            this.panelSubMenu.TabIndex = 4;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(0, 120);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(199, 40);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEscanner
            // 
            this.btnEscanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEscanner.FlatAppearance.BorderSize = 0;
            this.btnEscanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscanner.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscanner.ForeColor = System.Drawing.Color.White;
            this.btnEscanner.Location = new System.Drawing.Point(0, 80);
            this.btnEscanner.Name = "btnEscanner";
            this.btnEscanner.Size = new System.Drawing.Size(199, 40);
            this.btnEscanner.TabIndex = 4;
            this.btnEscanner.Text = "Escanner";
            this.btnEscanner.UseVisualStyleBackColor = true;
            this.btnEscanner.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_registros
            // 
            this.btn_registros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_registros.FlatAppearance.BorderSize = 0;
            this.btn_registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registros.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registros.ForeColor = System.Drawing.Color.White;
            this.btn_registros.Location = new System.Drawing.Point(0, 40);
            this.btn_registros.Name = "btn_registros";
            this.btn_registros.Size = new System.Drawing.Size(199, 40);
            this.btn_registros.TabIndex = 4;
            this.btn_registros.Text = "Historial de Accesos";
            this.btn_registros.UseVisualStyleBackColor = true;
            this.btn_registros.Click += new System.EventHandler(this.btn_registros_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.ForeColor = System.Drawing.Color.White;
            this.btn_usuarios.Location = new System.Drawing.Point(0, 0);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(199, 40);
            this.btn_usuarios.TabIndex = 4;
            this.btn_usuarios.Text = "Lista de Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AllowParentOverrides = false;
            this.lbl_user.AutoEllipsis = false;
            this.lbl_user.CursorType = null;
            this.lbl_user.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_user.Location = new System.Drawing.Point(74, 121);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_user.Size = new System.Drawing.Size(43, 30);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "User";
            this.lbl_user.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_user.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(52, 18);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 4;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.AllowAnimations = true;
            this.btn_cerrarSesion.AllowMouseEffects = true;
            this.btn_cerrarSesion.AllowToggling = false;
            this.btn_cerrarSesion.AnimationSpeed = 200;
            this.btn_cerrarSesion.AutoGenerateColors = false;
            this.btn_cerrarSesion.AutoRoundBorders = false;
            this.btn_cerrarSesion.AutoSizeLeftIcon = true;
            this.btn_cerrarSesion.AutoSizeRightIcon = true;
            this.btn_cerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrarSesion.BackColor1 = System.Drawing.Color.Firebrick;
            this.btn_cerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrarSesion.BackgroundImage")));
            this.btn_cerrarSesion.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_cerrarSesion.ButtonText = "Cerrar Sesion";
            this.btn_cerrarSesion.ButtonTextMarginLeft = 0;
            this.btn_cerrarSesion.ColorContrastOnClick = 45;
            this.btn_cerrarSesion.ColorContrastOnHover = 45;
            this.btn_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btn_cerrarSesion.CustomizableEdges = borderEdges5;
            this.btn_cerrarSesion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cerrarSesion.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_cerrarSesion.DisabledFillColor = System.Drawing.Color.IndianRed;
            this.btn_cerrarSesion.DisabledForecolor = System.Drawing.Color.IndianRed;
            this.btn_cerrarSesion.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btn_cerrarSesion.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrarSesion.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_cerrarSesion.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_cerrarSesion.IconMarginLeft = 11;
            this.btn_cerrarSesion.IconPadding = 10;
            this.btn_cerrarSesion.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cerrarSesion.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_cerrarSesion.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_cerrarSesion.IconSize = 25;
            this.btn_cerrarSesion.IdleBorderColor = System.Drawing.Color.Firebrick;
            this.btn_cerrarSesion.IdleBorderRadius = 10;
            this.btn_cerrarSesion.IdleBorderThickness = 1;
            this.btn_cerrarSesion.IdleFillColor = System.Drawing.Color.Firebrick;
            this.btn_cerrarSesion.IdleIconLeftImage = null;
            this.btn_cerrarSesion.IdleIconRightImage = null;
            this.btn_cerrarSesion.IndicateFocus = false;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(32, 598);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_cerrarSesion.OnDisabledState.BorderRadius = 10;
            this.btn_cerrarSesion.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_cerrarSesion.OnDisabledState.BorderThickness = 1;
            this.btn_cerrarSesion.OnDisabledState.FillColor = System.Drawing.Color.IndianRed;
            this.btn_cerrarSesion.OnDisabledState.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_cerrarSesion.OnDisabledState.IconLeftImage = null;
            this.btn_cerrarSesion.OnDisabledState.IconRightImage = null;
            this.btn_cerrarSesion.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.btn_cerrarSesion.onHoverState.BorderRadius = 10;
            this.btn_cerrarSesion.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_cerrarSesion.onHoverState.BorderThickness = 1;
            this.btn_cerrarSesion.onHoverState.FillColor = System.Drawing.Color.Brown;
            this.btn_cerrarSesion.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_cerrarSesion.onHoverState.IconLeftImage = null;
            this.btn_cerrarSesion.onHoverState.IconRightImage = null;
            this.btn_cerrarSesion.OnIdleState.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_cerrarSesion.OnIdleState.BorderRadius = 10;
            this.btn_cerrarSesion.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_cerrarSesion.OnIdleState.BorderThickness = 1;
            this.btn_cerrarSesion.OnIdleState.FillColor = System.Drawing.Color.Firebrick;
            this.btn_cerrarSesion.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_cerrarSesion.OnIdleState.IconLeftImage = null;
            this.btn_cerrarSesion.OnIdleState.IconRightImage = null;
            this.btn_cerrarSesion.OnPressedState.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_cerrarSesion.OnPressedState.BorderRadius = 10;
            this.btn_cerrarSesion.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_cerrarSesion.OnPressedState.BorderThickness = 1;
            this.btn_cerrarSesion.OnPressedState.FillColor = System.Drawing.Color.IndianRed;
            this.btn_cerrarSesion.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_cerrarSesion.OnPressedState.IconLeftImage = null;
            this.btn_cerrarSesion.OnPressedState.IconRightImage = null;
            this.btn_cerrarSesion.Size = new System.Drawing.Size(137, 33);
            this.btn_cerrarSesion.TabIndex = 1;
            this.btn_cerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cerrarSesion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_cerrarSesion.TextMarginLeft = 0;
            this.btn_cerrarSesion.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_cerrarSesion.UseDefaultRadiusAndThickness = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click_1);
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 0;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = false;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(-97, -198);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(1006, 1000);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 0;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            this.bunifuPictureBox2.Click += new System.EventHandler(this.bunifuPictureBox2_Click);
            // 
            // MenuOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.MenuOpciones_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.UI.WinForms.BunifuImageButton btn_cerrar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnEscanner;
        private System.Windows.Forms.Button btn_registros;
        private System.Windows.Forms.Button btn_usuarios;
        private Bunifu.UI.WinForms.BunifuLabel lbl_user;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_cerrarSesion;
        private System.Windows.Forms.Panel panelFormularios;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
    }
}