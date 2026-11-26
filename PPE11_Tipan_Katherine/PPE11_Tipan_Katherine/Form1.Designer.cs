namespace PPE11_Tipan_Katherine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "Empanada de queso", "Sanduche de Pollo", "Bolón de verde mixto", "Humita tradicional", "Tostada con queso", "Café pasado", "Chocolate caliente", "Jugo Natural", "Batido de fruta", "Botella de agua" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "", "empana" }, -1);
            ListViewItem listViewItem3 = new ListViewItem("");
            txtCliente = new TextBox();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            rbnMostrador = new RadioButton();
            rbtnEntrega = new RadioButton();
            lvCatalogo = new ListView();
            Producto = new ColumnHeader();
            Precio = new ColumnHeader();
            lvPedido = new ListView();
            chkPostre = new CheckBox();
            chkServilletas = new CheckBox();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnLimpiar = new Button();
            lblEstado = new Label();
            lblTotal = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lbnombre = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblDetalle = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(93, 59);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 27);
            txtCliente.TabIndex = 0;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(336, 59);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(204, 27);
            txtProducto.TabIndex = 1;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(648, 59);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 2;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // rbnMostrador
            // 
            rbnMostrador.AutoSize = true;
            rbnMostrador.Location = new Point(38, 26);
            rbnMostrador.Name = "rbnMostrador";
            rbnMostrador.Size = new Size(163, 24);
            rbnMostrador.TabIndex = 3;
            rbnMostrador.TabStop = true;
            rbnMostrador.Text = "Retiro en mostrador";
            rbnMostrador.UseVisualStyleBackColor = true;
            // 
            // rbtnEntrega
            // 
            rbtnEntrega.AutoSize = true;
            rbtnEntrega.Location = new Point(38, 56);
            rbtnEntrega.Name = "rbtnEntrega";
            rbtnEntrega.Size = new Size(192, 24);
            rbtnEntrega.TabIndex = 4;
            rbtnEntrega.TabStop = true;
            rbtnEntrega.Text = "Entrega en aula (+$0.50)";
            rbtnEntrega.UseVisualStyleBackColor = true;
            // 
            // lvCatalogo
            // 
            lvCatalogo.Columns.AddRange(new ColumnHeader[] { Producto, Precio });
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Productos";
            listViewGroup1.Tag = "Empanada de queso";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            lvCatalogo.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            listViewItem1.Group = listViewGroup1;
            listViewItem1.IndentCount = 1;
            lvCatalogo.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvCatalogo.Location = new Point(24, 138);
            lvCatalogo.Name = "lvCatalogo";
            lvCatalogo.Size = new Size(225, 211);
            lvCatalogo.TabIndex = 5;
            lvCatalogo.UseCompatibleStateImageBehavior = false;
            lvCatalogo.SelectedIndexChanged += label1_Click;
            // 
            // lvPedido
            // 
            lvPedido.Items.AddRange(new ListViewItem[] { listViewItem2, listViewItem3 });
            lvPedido.Location = new Point(548, 135);
            lvPedido.Name = "lvPedido";
            lvPedido.Size = new Size(222, 211);
            lvPedido.TabIndex = 6;
            lvPedido.UseCompatibleStateImageBehavior = false;
            lvPedido.SelectedIndexChanged += label1_Click;
            // 
            // chkPostre
            // 
            chkPostre.AutoSize = true;
            chkPostre.Location = new Point(21, 26);
            chkPostre.Name = "chkPostre";
            chkPostre.Size = new Size(180, 24);
            chkPostre.TabIndex = 7;
            chkPostre.Text = "Postre del día (+$1.00)";
            chkPostre.UseVisualStyleBackColor = true;
            // 
            // chkServilletas
            // 
            chkServilletas.AutoSize = true;
            chkServilletas.Location = new Point(21, 56);
            chkServilletas.Name = "chkServilletas";
            chkServilletas.Size = new Size(98, 24);
            chkServilletas.TabIndex = 8;
            chkServilletas.Text = "Servilletas";
            chkServilletas.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Enabled = false;
            btnAgregar.Location = new Point(236, 399);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Enabled = false;
            btnQuitar.Location = new Point(336, 399);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(94, 29);
            btnQuitar.TabIndex = 10;
            btnQuitar.Text = "Quitar Seleccionado";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(436, 399);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(39, 389);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado:";
            lblEstado.Click += lblEstado_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(588, 389);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total:";
            lblTotal.Click += lblTotal_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkServilletas);
            groupBox1.Controls.Add(chkPostre);
            groupBox1.Location = new Point(267, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 86);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Extras del producto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbnMostrador);
            groupBox2.Controls.Add(rbtnEntrega);
            groupBox2.Location = new Point(267, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 90);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modalidad de atención";
            // 
            // lbnombre
            // 
            lbnombre.AutoSize = true;
            lbnombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnombre.Location = new Point(25, 62);
            lbnombre.Name = "lbnombre";
            lbnombre.Size = new Size(71, 20);
            lbnombre.TabIndex = 16;
            lbnombre.Text = "Nombre:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(253, 59);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(77, 20);
            lblProducto.TabIndex = 17;
            lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(558, 62);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(75, 20);
            lblCantidad.TabIndex = 18;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalle.Location = new Point(548, 112);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(155, 20);
            lblDetalle.TabIndex = 19;
            lblDetalle.Text = "Detalle del producto:";
            lblDetalle.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 112);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 20;
            label1.Text = "Catálogo de productos:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblDetalle);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lbnombre);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTotal);
            Controls.Add(lblEstado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(lvPedido);
            Controls.Add(lvCatalogo);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(txtCliente);
            Name = "Form1";
            Text = "frmPedidoCafeteria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private RadioButton rbnMostrador;
        private RadioButton rbtnEntrega;
        private ListView lvCatalogo;
        private ListView lvPedido;
        private CheckBox chkPostre;
        private CheckBox chkServilletas;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnLimpiar;
        private Label lblEstado;
        private Label lblTotal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbnombre;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblDetalle;
        private Label label1;
        private ColumnHeader Producto;
        private ColumnHeader Precio;
    }
}
