<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.piclogin = New System.Windows.Forms.PictureBox()
        Me.piccont = New System.Windows.Forms.PictureBox()
        Me.txtusu = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.lblusu = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.btnentrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccont, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'piclogin
        '
        Me.piclogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.piclogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.piclogin.Image = Global.PlayasYMas.My.Resources.Resources.playashow
        Me.piclogin.Location = New System.Drawing.Point(283, 86)
        Me.piclogin.Name = "piclogin"
        Me.piclogin.Size = New System.Drawing.Size(206, 100)
        Me.piclogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclogin.TabIndex = 0
        Me.piclogin.TabStop = False
        '
        'piccont
        '
        Me.piccont.BackColor = System.Drawing.Color.Transparent
        Me.piccont.Image = Global.PlayasYMas.My.Resources.Resources.conter
        Me.piccont.Location = New System.Drawing.Point(198, 45)
        Me.piccont.Name = "piccont"
        Me.piccont.Size = New System.Drawing.Size(369, 404)
        Me.piccont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piccont.TabIndex = 1
        Me.piccont.TabStop = False
        '
        'txtusu
        '
        Me.txtusu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusu.Location = New System.Drawing.Point(309, 241)
        Me.txtusu.Name = "txtusu"
        Me.txtusu.Size = New System.Drawing.Size(146, 26)
        Me.txtusu.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(309, 302)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(146, 26)
        Me.txtpass.TabIndex = 3
        '
        'lblusu
        '
        Me.lblusu.AutoSize = True
        Me.lblusu.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusu.Location = New System.Drawing.Point(103, 160)
        Me.lblusu.Name = "lblusu"
        Me.lblusu.Size = New System.Drawing.Size(85, 26)
        Me.lblusu.TabIndex = 4
        Me.lblusu.Text = "Usuario"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.Location = New System.Drawing.Point(103, 221)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(122, 26)
        Me.lblpass.TabIndex = 6
        Me.lblpass.Text = "Contraseña"
        '
        'btnentrar
        '
        Me.btnentrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnentrar.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentrar.Location = New System.Drawing.Point(344, 367)
        Me.btnentrar.Name = "btnentrar"
        Me.btnentrar.Size = New System.Drawing.Size(71, 36)
        Me.btnentrar.TabIndex = 7
        Me.btnentrar.Text = "ENTRAR"
        Me.btnentrar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(458, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 20)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PlayasYMas.My.Resources.Resources.playa_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(774, 461)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnentrar)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lblusu)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusu)
        Me.Controls.Add(Me.piclogin)
        Me.Controls.Add(Me.piccont)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Playas Y Mas"
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccont, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents piclogin As PictureBox
    Friend WithEvents piccont As PictureBox
    Friend WithEvents txtusu As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents lblusu As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents btnentrar As Button
    Friend WithEvents Button1 As Button
End Class
