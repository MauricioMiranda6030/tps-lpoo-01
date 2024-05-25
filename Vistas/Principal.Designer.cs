namespace Vistas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panelReloj = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblUserOnLine = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.btnSistema = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnParticipante = new System.Windows.Forms.Button();
            this.btnCompetencias = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.subeMenuPart = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnAltaParticipante = new System.Windows.Forms.Button();
            this.subMenuComptencia = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBajaComp = new System.Windows.Forms.Button();
            this.btnAltaDis = new System.Windows.Forms.Button();
            this.btnAltaCat = new System.Windows.Forms.Button();
            this.subMenuEventos = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBajaEve = new System.Windows.Forms.Button();
            this.btnModiEve = new System.Windows.Forms.Button();
            this.btnAltaEve = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.subMenuUsuarios = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnABMUsuarios = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelReloj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.subeMenuPart.SuspendLayout();
            this.subMenuComptencia.SuspendLayout();
            this.subMenuEventos.SuspendLayout();
            this.subMenuUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.pictureBox1);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnClose);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1192, 38);
            this.BarraTitulo.TabIndex = 3;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1124, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1155, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelReloj
            // 
            this.panelReloj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.panelReloj.Controls.Add(this.Logo);
            this.panelReloj.Controls.Add(this.lblHora);
            this.panelReloj.Controls.Add(this.lblFecha);
            this.panelReloj.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelReloj.Location = new System.Drawing.Point(0, 38);
            this.panelReloj.Name = "panelReloj";
            this.panelReloj.Size = new System.Drawing.Size(275, 423);
            this.panelReloj.TabIndex = 4;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(276, 241);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblHora.Location = new System.Drawing.Point(58, 244);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(147, 54);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(81, 313);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(109, 39);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "label1";
            // 
            // lblUserOnLine
            // 
            this.lblUserOnLine.AutoSize = true;
            this.lblUserOnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOnLine.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserOnLine.Location = new System.Drawing.Point(629, 281);
            this.lblUserOnLine.Name = "lblUserOnLine";
            this.lblUserOnLine.Size = new System.Drawing.Size(243, 55);
            this.lblUserOnLine.TabIndex = 5;
            this.lblUserOnLine.Text = "USUARIO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Location = new System.Drawing.Point(439, 376);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(617, 48);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "CERRAR SESIÓN";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // btnSistema
            // 
            this.btnSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSistema.FlatAppearance.BorderSize = 0;
            this.btnSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistema.ForeColor = System.Drawing.Color.White;
            this.btnSistema.Image = ((System.Drawing.Image)(resources.GetObject("btnSistema.Image")));
            this.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSistema.Location = new System.Drawing.Point(337, 49);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(108, 37);
            this.btnSistema.TabIndex = 11;
            this.btnSistema.Text = "   SISTEMA";
            this.btnSistema.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.panel1.Location = new System.Drawing.Point(337, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 10);
            this.panel1.TabIndex = 12;
            // 
            // btnParticipante
            // 
            this.btnParticipante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParticipante.FlatAppearance.BorderSize = 0;
            this.btnParticipante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnParticipante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipante.ForeColor = System.Drawing.Color.White;
            this.btnParticipante.Image = ((System.Drawing.Image)(resources.GetObject("btnParticipante.Image")));
            this.btnParticipante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParticipante.Location = new System.Drawing.Point(439, 49);
            this.btnParticipante.Name = "btnParticipante";
            this.btnParticipante.Size = new System.Drawing.Size(169, 37);
            this.btnParticipante.TabIndex = 13;
            this.btnParticipante.Text = " PARTICIPANTES";
            this.btnParticipante.UseVisualStyleBackColor = true;
            this.btnParticipante.Click += new System.EventHandler(this.btnParticipante_Click);
            // 
            // btnCompetencias
            // 
            this.btnCompetencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompetencias.FlatAppearance.BorderSize = 0;
            this.btnCompetencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnCompetencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetencias.ForeColor = System.Drawing.Color.White;
            this.btnCompetencias.Image = ((System.Drawing.Image)(resources.GetObject("btnCompetencias.Image")));
            this.btnCompetencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompetencias.Location = new System.Drawing.Point(614, 49);
            this.btnCompetencias.Name = "btnCompetencias";
            this.btnCompetencias.Size = new System.Drawing.Size(168, 37);
            this.btnCompetencias.TabIndex = 14;
            this.btnCompetencias.Text = "   COMPETENCIAS";
            this.btnCompetencias.UseVisualStyleBackColor = true;
            this.btnCompetencias.Click += new System.EventHandler(this.btnCompetencias_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.ForeColor = System.Drawing.Color.White;
            this.btnEventos.Image = ((System.Drawing.Image)(resources.GetObject("btnEventos.Image")));
            this.btnEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventos.Location = new System.Drawing.Point(788, 49);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(119, 37);
            this.btnEventos.TabIndex = 15;
            this.btnEventos.Text = "    EVENTOS";
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // subeMenuPart
            // 
            this.subeMenuPart.Controls.Add(this.panel3);
            this.subeMenuPart.Controls.Add(this.btnBaja);
            this.subeMenuPart.Controls.Add(this.btnModificacion);
            this.subeMenuPart.Controls.Add(this.btnAltaParticipante);
            this.subeMenuPart.Location = new System.Drawing.Point(439, 92);
            this.subeMenuPart.Name = "subeMenuPart";
            this.subeMenuPart.Size = new System.Drawing.Size(162, 99);
            this.subeMenuPart.TabIndex = 16;
            this.subeMenuPart.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 98);
            this.panel3.TabIndex = 17;
            // 
            // btnBaja
            // 
            this.btnBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaja.FlatAppearance.BorderSize = 0;
            this.btnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.Color.White;
            this.btnBaja.Image = ((System.Drawing.Image)(resources.GetObject("btnBaja.Image")));
            this.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaja.Location = new System.Drawing.Point(15, 68);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(115, 26);
            this.btnBaja.TabIndex = 19;
            this.btnBaja.Text = "    ELIMINAR";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificacion.FlatAppearance.BorderSize = 0;
            this.btnModificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificacion.ForeColor = System.Drawing.Color.White;
            this.btnModificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnModificacion.Image")));
            this.btnModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificacion.Location = new System.Drawing.Point(15, 35);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(143, 31);
            this.btnModificacion.TabIndex = 18;
            this.btnModificacion.Text = "MODIFICAR";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnAltaParticipante
            // 
            this.btnAltaParticipante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaParticipante.FlatAppearance.BorderSize = 0;
            this.btnAltaParticipante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnAltaParticipante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaParticipante.ForeColor = System.Drawing.Color.White;
            this.btnAltaParticipante.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaParticipante.Image")));
            this.btnAltaParticipante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaParticipante.Location = new System.Drawing.Point(15, 3);
            this.btnAltaParticipante.Name = "btnAltaParticipante";
            this.btnAltaParticipante.Size = new System.Drawing.Size(115, 26);
            this.btnAltaParticipante.TabIndex = 17;
            this.btnAltaParticipante.Text = "     AGREGAR";
            this.btnAltaParticipante.UseVisualStyleBackColor = true;
            this.btnAltaParticipante.Click += new System.EventHandler(this.btnAltaParticipante_Click);
            // 
            // subMenuComptencia
            // 
            this.subMenuComptencia.Controls.Add(this.panel4);
            this.subMenuComptencia.Controls.Add(this.btnBajaComp);
            this.subMenuComptencia.Controls.Add(this.btnAltaDis);
            this.subMenuComptencia.Controls.Add(this.btnAltaCat);
            this.subMenuComptencia.Location = new System.Drawing.Point(614, 92);
            this.subMenuComptencia.Name = "subMenuComptencia";
            this.subMenuComptencia.Size = new System.Drawing.Size(162, 99);
            this.subMenuComptencia.TabIndex = 17;
            this.subMenuComptencia.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 98);
            this.panel4.TabIndex = 17;
            // 
            // btnBajaComp
            // 
            this.btnBajaComp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajaComp.FlatAppearance.BorderSize = 0;
            this.btnBajaComp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnBajaComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaComp.ForeColor = System.Drawing.Color.White;
            this.btnBajaComp.Image = ((System.Drawing.Image)(resources.GetObject("btnBajaComp.Image")));
            this.btnBajaComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaComp.Location = new System.Drawing.Point(15, 68);
            this.btnBajaComp.Name = "btnBajaComp";
            this.btnBajaComp.Size = new System.Drawing.Size(99, 26);
            this.btnBajaComp.TabIndex = 19;
            this.btnBajaComp.Text = "BAJA";
            this.btnBajaComp.UseVisualStyleBackColor = true;
            this.btnBajaComp.Click += new System.EventHandler(this.btnBajaComp_Click);
            // 
            // btnAltaDis
            // 
            this.btnAltaDis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaDis.FlatAppearance.BorderSize = 0;
            this.btnAltaDis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnAltaDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaDis.ForeColor = System.Drawing.Color.White;
            this.btnAltaDis.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaDis.Image")));
            this.btnAltaDis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaDis.Location = new System.Drawing.Point(15, 36);
            this.btnAltaDis.Name = "btnAltaDis";
            this.btnAltaDis.Size = new System.Drawing.Size(117, 31);
            this.btnAltaDis.TabIndex = 18;
            this.btnAltaDis.Text = "    DISCIPLINA";
            this.btnAltaDis.UseVisualStyleBackColor = true;
            this.btnAltaDis.Click += new System.EventHandler(this.btnAltaDis_Click);
            // 
            // btnAltaCat
            // 
            this.btnAltaCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaCat.FlatAppearance.BorderSize = 0;
            this.btnAltaCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnAltaCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCat.ForeColor = System.Drawing.Color.White;
            this.btnAltaCat.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaCat.Image")));
            this.btnAltaCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCat.Location = new System.Drawing.Point(15, 3);
            this.btnAltaCat.Name = "btnAltaCat";
            this.btnAltaCat.Size = new System.Drawing.Size(131, 26);
            this.btnAltaCat.TabIndex = 17;
            this.btnAltaCat.Text = "   CATEGORIA";
            this.btnAltaCat.UseVisualStyleBackColor = true;
            this.btnAltaCat.Click += new System.EventHandler(this.btnAltaCat_Click);
            // 
            // subMenuEventos
            // 
            this.subMenuEventos.Controls.Add(this.panel5);
            this.subMenuEventos.Controls.Add(this.btnBajaEve);
            this.subMenuEventos.Controls.Add(this.btnModiEve);
            this.subMenuEventos.Controls.Add(this.btnAltaEve);
            this.subMenuEventos.Location = new System.Drawing.Point(788, 91);
            this.subMenuEventos.Name = "subMenuEventos";
            this.subMenuEventos.Size = new System.Drawing.Size(166, 99);
            this.subMenuEventos.TabIndex = 18;
            this.subMenuEventos.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.panel5.Location = new System.Drawing.Point(3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 98);
            this.panel5.TabIndex = 17;
            // 
            // btnBajaEve
            // 
            this.btnBajaEve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajaEve.FlatAppearance.BorderSize = 0;
            this.btnBajaEve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnBajaEve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaEve.ForeColor = System.Drawing.Color.White;
            this.btnBajaEve.Image = ((System.Drawing.Image)(resources.GetObject("btnBajaEve.Image")));
            this.btnBajaEve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaEve.Location = new System.Drawing.Point(15, 68);
            this.btnBajaEve.Name = "btnBajaEve";
            this.btnBajaEve.Size = new System.Drawing.Size(120, 26);
            this.btnBajaEve.TabIndex = 19;
            this.btnBajaEve.Text = "ELIMINAR";
            this.btnBajaEve.UseVisualStyleBackColor = true;
            this.btnBajaEve.Click += new System.EventHandler(this.btnBajaEve_Click);
            // 
            // btnModiEve
            // 
            this.btnModiEve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModiEve.FlatAppearance.BorderSize = 0;
            this.btnModiEve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnModiEve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModiEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModiEve.ForeColor = System.Drawing.Color.White;
            this.btnModiEve.Image = ((System.Drawing.Image)(resources.GetObject("btnModiEve.Image")));
            this.btnModiEve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModiEve.Location = new System.Drawing.Point(15, 35);
            this.btnModiEve.Name = "btnModiEve";
            this.btnModiEve.Size = new System.Drawing.Size(135, 31);
            this.btnModiEve.TabIndex = 18;
            this.btnModiEve.Text = "MODIFICAR";
            this.btnModiEve.UseVisualStyleBackColor = true;
            this.btnModiEve.Click += new System.EventHandler(this.btnModiEve_Click);
            // 
            // btnAltaEve
            // 
            this.btnAltaEve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaEve.FlatAppearance.BorderSize = 0;
            this.btnAltaEve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnAltaEve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaEve.ForeColor = System.Drawing.Color.White;
            this.btnAltaEve.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaEve.Image")));
            this.btnAltaEve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaEve.Location = new System.Drawing.Point(15, 3);
            this.btnAltaEve.Name = "btnAltaEve";
            this.btnAltaEve.Size = new System.Drawing.Size(120, 26);
            this.btnAltaEve.TabIndex = 17;
            this.btnAltaEve.Text = "   AGREGAR";
            this.btnAltaEve.UseVisualStyleBackColor = true;
            this.btnAltaEve.Click += new System.EventHandler(this.btnAltaEve_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(913, 48);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(110, 37);
            this.btnUsuarios.TabIndex = 19;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // subMenuUsuarios
            // 
            this.subMenuUsuarios.Controls.Add(this.panel6);
            this.subMenuUsuarios.Controls.Add(this.btnABMUsuarios);
            this.subMenuUsuarios.Location = new System.Drawing.Point(968, 92);
            this.subMenuUsuarios.Name = "subMenuUsuarios";
            this.subMenuUsuarios.Size = new System.Drawing.Size(166, 37);
            this.subMenuUsuarios.TabIndex = 20;
            this.subMenuUsuarios.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.panel6.Location = new System.Drawing.Point(3, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 98);
            this.panel6.TabIndex = 17;
            // 
            // btnABMUsuarios
            // 
            this.btnABMUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnABMUsuarios.FlatAppearance.BorderSize = 0;
            this.btnABMUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnABMUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnABMUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnABMUsuarios.Image")));
            this.btnABMUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABMUsuarios.Location = new System.Drawing.Point(15, 3);
            this.btnABMUsuarios.Name = "btnABMUsuarios";
            this.btnABMUsuarios.Size = new System.Drawing.Size(120, 26);
            this.btnABMUsuarios.TabIndex = 17;
            this.btnABMUsuarios.Text = " ABM";
            this.btnABMUsuarios.UseVisualStyleBackColor = true;
            this.btnABMUsuarios.Click += new System.EventHandler(this.btnABMUsuarios_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1192, 461);
            this.Controls.Add(this.subMenuUsuarios);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.subMenuEventos);
            this.Controls.Add(this.subMenuComptencia);
            this.Controls.Add(this.subeMenuPart);
            this.Controls.Add(this.btnEventos);
            this.Controls.Add(this.btnCompetencias);
            this.Controls.Add(this.btnParticipante);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSistema);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblUserOnLine);
            this.Controls.Add(this.panelReloj);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelReloj.ResumeLayout(false);
            this.panelReloj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.subeMenuPart.ResumeLayout(false);
            this.subMenuComptencia.ResumeLayout(false);
            this.subMenuEventos.ResumeLayout(false);
            this.subMenuUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panelReloj;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblUserOnLine;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnParticipante;
        private System.Windows.Forms.Button btnCompetencias;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Panel subeMenuPart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnAltaParticipante;
        private System.Windows.Forms.Panel subMenuComptencia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBajaComp;
        private System.Windows.Forms.Button btnAltaDis;
        private System.Windows.Forms.Button btnAltaCat;
        private System.Windows.Forms.Panel subMenuEventos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBajaEve;
        private System.Windows.Forms.Button btnModiEve;
        private System.Windows.Forms.Button btnAltaEve;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel subMenuUsuarios;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnABMUsuarios;
    }
}