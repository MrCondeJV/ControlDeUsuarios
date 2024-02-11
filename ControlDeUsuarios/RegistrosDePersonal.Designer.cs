namespace ControlDeUsuarios
{
    partial class RegistrosDePersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosDePersonal));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.txtBuscarUID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTabla = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UIDTargeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Buscar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registros del Personal";
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Location = new System.Drawing.Point(65, 113);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarID.TabIndex = 2;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(194, 113);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarNombre.TabIndex = 3;
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.Location = new System.Drawing.Point(326, 113);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarApellido.TabIndex = 4;
            // 
            // txtBuscarUID
            // 
            this.txtBuscarUID.Location = new System.Drawing.Point(451, 113);
            this.txtBuscarUID.Name = "txtBuscarUID";
            this.txtBuscarUID.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarUID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "UID";
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.Apellido,
            this.Entrada,
            this.Salida,
            this.UIDTargeta});
            this.dgvTabla.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvTabla.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTabla.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTabla.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTabla.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTabla.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvTabla.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTabla.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTabla.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvTabla.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTabla.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvTabla.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTabla.CurrentTheme.Name = null;
            this.dgvTabla.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTabla.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTabla.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTabla.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTabla.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTabla.EnableHeadersVisualStyles = false;
            this.dgvTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTabla.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTabla.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvTabla.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTabla.Location = new System.Drawing.Point(65, 170);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.RowTemplate.Height = 40;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(661, 365);
            this.dgvTabla.TabIndex = 12;
            this.dgvTabla.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            // 
            // UIDTargeta
            // 
            this.UIDTargeta.HeaderText = "UID";
            this.UIDTargeta.Name = "UIDTargeta";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.AllowAnimations = true;
            this.btn_Buscar.AllowMouseEffects = true;
            this.btn_Buscar.AllowToggling = false;
            this.btn_Buscar.AnimationSpeed = 200;
            this.btn_Buscar.AutoGenerateColors = false;
            this.btn_Buscar.AutoRoundBorders = false;
            this.btn_Buscar.AutoSizeLeftIcon = true;
            this.btn_Buscar.AutoSizeRightIcon = true;
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.BackgroundImage")));
            this.btn_Buscar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Buscar.ButtonText = "Buscar";
            this.btn_Buscar.ButtonTextMarginLeft = 0;
            this.btn_Buscar.ColorContrastOnClick = 45;
            this.btn_Buscar.ColorContrastOnHover = 45;
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Buscar.CustomizableEdges = borderEdges1;
            this.btn_Buscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Buscar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Buscar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_Buscar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_Buscar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.IconLeft = null;
            this.btn_Buscar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Buscar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Buscar.IconMarginLeft = 11;
            this.btn_Buscar.IconPadding = 10;
            this.btn_Buscar.IconRight = null;
            this.btn_Buscar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Buscar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Buscar.IconSize = 25;
            this.btn_Buscar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_Buscar.IdleBorderRadius = 0;
            this.btn_Buscar.IdleBorderThickness = 0;
            this.btn_Buscar.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_Buscar.IdleIconLeftImage = null;
            this.btn_Buscar.IdleIconRightImage = null;
            this.btn_Buscar.IndicateFocus = false;
            this.btn_Buscar.Location = new System.Drawing.Point(610, 103);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Buscar.OnDisabledState.BorderRadius = 1;
            this.btn_Buscar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Buscar.OnDisabledState.BorderThickness = 1;
            this.btn_Buscar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Buscar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Buscar.OnDisabledState.IconLeftImage = null;
            this.btn_Buscar.OnDisabledState.IconRightImage = null;
            this.btn_Buscar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_Buscar.onHoverState.BorderRadius = 1;
            this.btn_Buscar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Buscar.onHoverState.BorderThickness = 1;
            this.btn_Buscar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_Buscar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.onHoverState.IconLeftImage = null;
            this.btn_Buscar.onHoverState.IconRightImage = null;
            this.btn_Buscar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Buscar.OnIdleState.BorderRadius = 1;
            this.btn_Buscar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Buscar.OnIdleState.BorderThickness = 1;
            this.btn_Buscar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Buscar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.OnIdleState.IconLeftImage = null;
            this.btn_Buscar.OnIdleState.IconRightImage = null;
            this.btn_Buscar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Buscar.OnPressedState.BorderRadius = 1;
            this.btn_Buscar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Buscar.OnPressedState.BorderThickness = 1;
            this.btn_Buscar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Buscar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.OnPressedState.IconLeftImage = null;
            this.btn_Buscar.OnPressedState.IconRightImage = null;
            this.btn_Buscar.Size = new System.Drawing.Size(131, 30);
            this.btn_Buscar.TabIndex = 13;
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Buscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Buscar.TextMarginLeft = 0;
            this.btn_Buscar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Buscar.UseDefaultRadiusAndThickness = true;
            this.btn_Buscar.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // RegistrosDePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 606);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarUID);
            this.Controls.Add(this.txtBuscarApellido);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.txtBuscarID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrosDePersonal";
            this.Text = "RegistrosDePersonal";
            this.Load += new System.EventHandler(this.RegistrosDePersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarID;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.TextBox txtBuscarUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn UIDTargeta;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Buscar;
    }
}