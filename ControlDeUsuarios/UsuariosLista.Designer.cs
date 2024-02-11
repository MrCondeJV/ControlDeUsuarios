namespace ControlDeUsuarios
{
    partial class UsuariosLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosLista));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDTrabajador = new System.Windows.Forms.TextBox();
            this.txtNombreTrabajador = new System.Windows.Forms.TextBox();
            this.txtApellidoTrabajador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUIDTargeta = new System.Windows.Forms.TextBox();
            this.btn_AsignarTargeta = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvDatos = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAgregar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEliminar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO";
            // 
            // txtIDTrabajador
            // 
            this.txtIDTrabajador.Location = new System.Drawing.Point(148, 31);
            this.txtIDTrabajador.Name = "txtIDTrabajador";
            this.txtIDTrabajador.Size = new System.Drawing.Size(148, 22);
            this.txtIDTrabajador.TabIndex = 5;
            // 
            // txtNombreTrabajador
            // 
            this.txtNombreTrabajador.Location = new System.Drawing.Point(148, 75);
            this.txtNombreTrabajador.Name = "txtNombreTrabajador";
            this.txtNombreTrabajador.Size = new System.Drawing.Size(148, 22);
            this.txtNombreTrabajador.TabIndex = 6;
            // 
            // txtApellidoTrabajador
            // 
            this.txtApellidoTrabajador.Location = new System.Drawing.Point(148, 132);
            this.txtApellidoTrabajador.Name = "txtApellidoTrabajador";
            this.txtApellidoTrabajador.Size = new System.Drawing.Size(148, 22);
            this.txtApellidoTrabajador.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID";
            // 
            // txtUIDTargeta
            // 
            this.txtUIDTargeta.Location = new System.Drawing.Point(501, 34);
            this.txtUIDTargeta.Name = "txtUIDTargeta";
            this.txtUIDTargeta.Size = new System.Drawing.Size(148, 22);
            this.txtUIDTargeta.TabIndex = 11;
            this.txtUIDTargeta.TextChanged += new System.EventHandler(this.txtUIDTargeta_TextChanged);
            // 
            // btn_AsignarTargeta
            // 
            this.btn_AsignarTargeta.AllowAnimations = true;
            this.btn_AsignarTargeta.AllowMouseEffects = true;
            this.btn_AsignarTargeta.AllowToggling = false;
            this.btn_AsignarTargeta.AnimationSpeed = 200;
            this.btn_AsignarTargeta.AutoGenerateColors = false;
            this.btn_AsignarTargeta.AutoRoundBorders = false;
            this.btn_AsignarTargeta.AutoSizeLeftIcon = true;
            this.btn_AsignarTargeta.AutoSizeRightIcon = true;
            this.btn_AsignarTargeta.BackColor = System.Drawing.Color.Transparent;
            this.btn_AsignarTargeta.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_AsignarTargeta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AsignarTargeta.BackgroundImage")));
            this.btn_AsignarTargeta.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_AsignarTargeta.ButtonText = "Asignar Tarjeta";
            this.btn_AsignarTargeta.ButtonTextMarginLeft = 0;
            this.btn_AsignarTargeta.ColorContrastOnClick = 45;
            this.btn_AsignarTargeta.ColorContrastOnHover = 45;
            this.btn_AsignarTargeta.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_AsignarTargeta.CustomizableEdges = borderEdges1;
            this.btn_AsignarTargeta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AsignarTargeta.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_AsignarTargeta.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_AsignarTargeta.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_AsignarTargeta.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_AsignarTargeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AsignarTargeta.ForeColor = System.Drawing.Color.White;
            this.btn_AsignarTargeta.IconLeft = null;
            this.btn_AsignarTargeta.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AsignarTargeta.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_AsignarTargeta.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_AsignarTargeta.IconMarginLeft = 11;
            this.btn_AsignarTargeta.IconPadding = 10;
            this.btn_AsignarTargeta.IconRight = null;
            this.btn_AsignarTargeta.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AsignarTargeta.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_AsignarTargeta.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_AsignarTargeta.IconSize = 25;
            this.btn_AsignarTargeta.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_AsignarTargeta.IdleBorderRadius = 0;
            this.btn_AsignarTargeta.IdleBorderThickness = 0;
            this.btn_AsignarTargeta.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_AsignarTargeta.IdleIconLeftImage = null;
            this.btn_AsignarTargeta.IdleIconRightImage = null;
            this.btn_AsignarTargeta.IndicateFocus = false;
            this.btn_AsignarTargeta.Location = new System.Drawing.Point(511, 75);
            this.btn_AsignarTargeta.Name = "btn_AsignarTargeta";
            this.btn_AsignarTargeta.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_AsignarTargeta.OnDisabledState.BorderRadius = 1;
            this.btn_AsignarTargeta.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_AsignarTargeta.OnDisabledState.BorderThickness = 1;
            this.btn_AsignarTargeta.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_AsignarTargeta.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_AsignarTargeta.OnDisabledState.IconLeftImage = null;
            this.btn_AsignarTargeta.OnDisabledState.IconRightImage = null;
            this.btn_AsignarTargeta.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_AsignarTargeta.onHoverState.BorderRadius = 1;
            this.btn_AsignarTargeta.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_AsignarTargeta.onHoverState.BorderThickness = 1;
            this.btn_AsignarTargeta.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_AsignarTargeta.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_AsignarTargeta.onHoverState.IconLeftImage = null;
            this.btn_AsignarTargeta.onHoverState.IconRightImage = null;
            this.btn_AsignarTargeta.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_AsignarTargeta.OnIdleState.BorderRadius = 1;
            this.btn_AsignarTargeta.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_AsignarTargeta.OnIdleState.BorderThickness = 1;
            this.btn_AsignarTargeta.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_AsignarTargeta.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_AsignarTargeta.OnIdleState.IconLeftImage = null;
            this.btn_AsignarTargeta.OnIdleState.IconRightImage = null;
            this.btn_AsignarTargeta.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_AsignarTargeta.OnPressedState.BorderRadius = 1;
            this.btn_AsignarTargeta.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_AsignarTargeta.OnPressedState.BorderThickness = 1;
            this.btn_AsignarTargeta.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_AsignarTargeta.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_AsignarTargeta.OnPressedState.IconLeftImage = null;
            this.btn_AsignarTargeta.OnPressedState.IconRightImage = null;
            this.btn_AsignarTargeta.Size = new System.Drawing.Size(116, 27);
            this.btn_AsignarTargeta.TabIndex = 14;
            this.btn_AsignarTargeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AsignarTargeta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AsignarTargeta.TextMarginLeft = 0;
            this.btn_AsignarTargeta.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_AsignarTargeta.UseDefaultRadiusAndThickness = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.ColumnHeadersHeight = 40;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellido,
            this.uid});
            this.dgvDatos.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvDatos.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDatos.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDatos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDatos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatos.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvDatos.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDatos.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDatos.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDatos.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDatos.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvDatos.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatos.CurrentTheme.Name = null;
            this.dgvDatos.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatos.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDatos.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDatos.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDatos.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDatos.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDatos.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDatos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDatos.Location = new System.Drawing.Point(70, 257);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Height = 40;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(621, 274);
            this.dgvDatos.TabIndex = 15;
            this.dgvDatos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // uid
            // 
            this.uid.HeaderText = "UID TARJETA";
            this.uid.Name = "uid";
            // 
            // btnModificar
            // 
            this.btnModificar.AllowAnimations = true;
            this.btnModificar.AllowMouseEffects = true;
            this.btnModificar.AllowToggling = false;
            this.btnModificar.AnimationSpeed = 200;
            this.btnModificar.AutoGenerateColors = false;
            this.btnModificar.AutoRoundBorders = false;
            this.btnModificar.AutoSizeLeftIcon = true;
            this.btnModificar.AutoSizeRightIcon = true;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificar.ButtonText = "Modificar";
            this.btnModificar.ButtonTextMarginLeft = 0;
            this.btnModificar.ColorContrastOnClick = 45;
            this.btnModificar.ColorContrastOnHover = 45;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnModificar.CustomizableEdges = borderEdges2;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnModificar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnModificar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconLeft = null;
            this.btnModificar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnModificar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnModificar.IconMarginLeft = 11;
            this.btnModificar.IconPadding = 10;
            this.btnModificar.IconRight = null;
            this.btnModificar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnModificar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnModificar.IconSize = 25;
            this.btnModificar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnModificar.IdleBorderRadius = 0;
            this.btnModificar.IdleBorderThickness = 0;
            this.btnModificar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnModificar.IdleIconLeftImage = null;
            this.btnModificar.IdleIconRightImage = null;
            this.btnModificar.IndicateFocus = false;
            this.btnModificar.Location = new System.Drawing.Point(306, 187);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificar.OnDisabledState.BorderRadius = 1;
            this.btnModificar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificar.OnDisabledState.BorderThickness = 1;
            this.btnModificar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnModificar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnModificar.OnDisabledState.IconLeftImage = null;
            this.btnModificar.OnDisabledState.IconRightImage = null;
            this.btnModificar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificar.onHoverState.BorderRadius = 1;
            this.btnModificar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificar.onHoverState.BorderThickness = 1;
            this.btnModificar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnModificar.onHoverState.IconLeftImage = null;
            this.btnModificar.onHoverState.IconRightImage = null;
            this.btnModificar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.OnIdleState.BorderRadius = 1;
            this.btnModificar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificar.OnIdleState.BorderThickness = 1;
            this.btnModificar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnModificar.OnIdleState.IconLeftImage = null;
            this.btnModificar.OnIdleState.IconRightImage = null;
            this.btnModificar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.OnPressedState.BorderRadius = 1;
            this.btnModificar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificar.OnPressedState.BorderThickness = 1;
            this.btnModificar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnModificar.OnPressedState.IconLeftImage = null;
            this.btnModificar.OnPressedState.IconRightImage = null;
            this.btnModificar.Size = new System.Drawing.Size(90, 27);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar.TextMarginLeft = 0;
            this.btnModificar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnModificar.UseDefaultRadiusAndThickness = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AllowAnimations = true;
            this.btnAgregar.AllowMouseEffects = true;
            this.btnAgregar.AllowToggling = false;
            this.btnAgregar.AnimationSpeed = 200;
            this.btnAgregar.AutoGenerateColors = false;
            this.btnAgregar.AutoRoundBorders = false;
            this.btnAgregar.AutoSizeLeftIcon = true;
            this.btnAgregar.AutoSizeRightIcon = true;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.ButtonTextMarginLeft = 0;
            this.btnAgregar.ColorContrastOnClick = 45;
            this.btnAgregar.ColorContrastOnHover = 45;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAgregar.CustomizableEdges = borderEdges3;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAgregar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAgregar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconLeft = null;
            this.btnAgregar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregar.IconMarginLeft = 11;
            this.btnAgregar.IconPadding = 10;
            this.btnAgregar.IconRight = null;
            this.btnAgregar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAgregar.IdleBorderRadius = 0;
            this.btnAgregar.IdleBorderThickness = 0;
            this.btnAgregar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAgregar.IdleIconLeftImage = null;
            this.btnAgregar.IdleIconRightImage = null;
            this.btnAgregar.IndicateFocus = false;
            this.btnAgregar.Location = new System.Drawing.Point(148, 187);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregar.OnDisabledState.BorderRadius = 1;
            this.btnAgregar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregar.OnDisabledState.BorderThickness = 1;
            this.btnAgregar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregar.OnDisabledState.IconLeftImage = null;
            this.btnAgregar.OnDisabledState.IconRightImage = null;
            this.btnAgregar.onHoverState.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnAgregar.onHoverState.BorderRadius = 1;
            this.btnAgregar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregar.onHoverState.BorderThickness = 1;
            this.btnAgregar.onHoverState.FillColor = System.Drawing.Color.SpringGreen;
            this.btnAgregar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.onHoverState.IconLeftImage = null;
            this.btnAgregar.onHoverState.IconRightImage = null;
            this.btnAgregar.OnIdleState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.OnIdleState.BorderRadius = 1;
            this.btnAgregar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregar.OnIdleState.BorderThickness = 1;
            this.btnAgregar.OnIdleState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnIdleState.IconLeftImage = null;
            this.btnAgregar.OnIdleState.IconRightImage = null;
            this.btnAgregar.OnPressedState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.OnPressedState.BorderRadius = 1;
            this.btnAgregar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregar.OnPressedState.BorderThickness = 1;
            this.btnAgregar.OnPressedState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnPressedState.IconLeftImage = null;
            this.btnAgregar.OnPressedState.IconRightImage = null;
            this.btnAgregar.Size = new System.Drawing.Size(90, 27);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregar.TextMarginLeft = 0;
            this.btnAgregar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAgregar.UseDefaultRadiusAndThickness = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AllowAnimations = true;
            this.btnEliminar.AllowMouseEffects = true;
            this.btnEliminar.AllowToggling = false;
            this.btnEliminar.AnimationSpeed = 200;
            this.btnEliminar.AutoGenerateColors = false;
            this.btnEliminar.AutoRoundBorders = false;
            this.btnEliminar.AutoSizeLeftIcon = true;
            this.btnEliminar.AutoSizeRightIcon = true;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.ButtonTextMarginLeft = 0;
            this.btnEliminar.ColorContrastOnClick = 45;
            this.btnEliminar.ColorContrastOnHover = 45;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnEliminar.CustomizableEdges = borderEdges4;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEliminar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnEliminar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnEliminar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconLeft = null;
            this.btnEliminar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEliminar.IconMarginLeft = 11;
            this.btnEliminar.IconPadding = 10;
            this.btnEliminar.IconRight = null;
            this.btnEliminar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnEliminar.IdleBorderRadius = 0;
            this.btnEliminar.IdleBorderThickness = 0;
            this.btnEliminar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnEliminar.IdleIconLeftImage = null;
            this.btnEliminar.IdleIconRightImage = null;
            this.btnEliminar.IndicateFocus = false;
            this.btnEliminar.Location = new System.Drawing.Point(478, 187);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEliminar.OnDisabledState.BorderRadius = 1;
            this.btnEliminar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.OnDisabledState.BorderThickness = 1;
            this.btnEliminar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEliminar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEliminar.OnDisabledState.IconLeftImage = null;
            this.btnEliminar.OnDisabledState.IconRightImage = null;
            this.btnEliminar.onHoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.onHoverState.BorderRadius = 1;
            this.btnEliminar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.onHoverState.BorderThickness = 1;
            this.btnEliminar.onHoverState.FillColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.onHoverState.IconLeftImage = null;
            this.btnEliminar.onHoverState.IconRightImage = null;
            this.btnEliminar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.OnIdleState.BorderRadius = 1;
            this.btnEliminar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.OnIdleState.BorderThickness = 1;
            this.btnEliminar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnIdleState.IconLeftImage = null;
            this.btnEliminar.OnIdleState.IconRightImage = null;
            this.btnEliminar.OnPressedState.BorderColor = System.Drawing.Color.Maroon;
            this.btnEliminar.OnPressedState.BorderRadius = 1;
            this.btnEliminar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.OnPressedState.BorderThickness = 1;
            this.btnEliminar.OnPressedState.FillColor = System.Drawing.Color.Maroon;
            this.btnEliminar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnPressedState.IconLeftImage = null;
            this.btnEliminar.OnPressedState.IconRightImage = null;
            this.btnEliminar.Size = new System.Drawing.Size(90, 27);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.TextMarginLeft = 0;
            this.btnEliminar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEliminar.UseDefaultRadiusAndThickness = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // UsuariosLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 606);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btn_AsignarTargeta);
            this.Controls.Add(this.txtUIDTargeta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellidoTrabajador);
            this.Controls.Add(this.txtNombreTrabajador);
            this.Controls.Add(this.txtIDTrabajador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsuariosLista";
            this.Text = "UsuariosLista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDTrabajador;
        private System.Windows.Forms.TextBox txtNombreTrabajador;
        private System.Windows.Forms.TextBox txtApellidoTrabajador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUIDTargeta;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_AsignarTargeta;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDatos;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnModificar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
    }
}