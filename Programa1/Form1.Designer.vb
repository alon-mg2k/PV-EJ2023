<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Problema1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeader = New Label()
        tbNumero = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        tbIntentosExitosos = New TextBox()
        tbIntentosFallidos = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        tbIntentosOmitidos = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(12, 26)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(406, 25)
        lblHeader.TabIndex = 0
        lblHeader.Text = "¿Adivina que número estoy pensando? (0 AL 9)"
        ' 
        ' tbNumero
        ' 
        tbNumero.BackColor = Color.Black
        tbNumero.ForeColor = Color.White
        tbNumero.Location = New Point(176, 95)
        tbNumero.Name = "tbNumero"
        tbNumero.Size = New Size(249, 23)
        tbNumero.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(14, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 15)
        Label1.TabIndex = 2
        Label1.Text = "Ingrese el número a adivinar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 15)
        Label2.TabIndex = 3
        Label2.Text = "Intentos acertados"
        ' 
        ' tbIntentosExitosos
        ' 
        tbIntentosExitosos.BackColor = Color.Black
        tbIntentosExitosos.ForeColor = Color.White
        tbIntentosExitosos.Location = New Point(13, 234)
        tbIntentosExitosos.Name = "tbIntentosExitosos"
        tbIntentosExitosos.ReadOnly = True
        tbIntentosExitosos.Size = New Size(412, 23)
        tbIntentosExitosos.TabIndex = 4
        ' 
        ' tbIntentosFallidos
        ' 
        tbIntentosFallidos.BackColor = Color.Black
        tbIntentosFallidos.ForeColor = Color.White
        tbIntentosFallidos.Location = New Point(13, 279)
        tbIntentosFallidos.Name = "tbIntentosFallidos"
        tbIntentosFallidos.ReadOnly = True
        tbIntentosFallidos.Size = New Size(412, 23)
        tbIntentosFallidos.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(13, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 15)
        Label3.TabIndex = 5
        Label3.Text = "Intentos faliidos"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.White
        Button1.Location = New Point(12, 141)
        Button1.Name = "Button1"
        Button1.Size = New Size(413, 33)
        Button1.TabIndex = 7
        Button1.Text = "Es ese!"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.ForeColor = Color.White
        Button2.Location = New Point(12, 180)
        Button2.Name = "Button2"
        Button2.Size = New Size(413, 33)
        Button2.TabIndex = 8
        Button2.Text = "Siguiente número"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' tbIntentosOmitidos
        ' 
        tbIntentosOmitidos.BackColor = Color.Black
        tbIntentosOmitidos.ForeColor = Color.White
        tbIntentosOmitidos.Location = New Point(14, 324)
        tbIntentosOmitidos.Name = "tbIntentosOmitidos"
        tbIntentosOmitidos.ReadOnly = True
        tbIntentosOmitidos.Size = New Size(411, 23)
        tbIntentosOmitidos.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(13, 306)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 9
        Label4.Text = "Intentos omitidos"
        ' 
        ' Problema1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.WindowFrame
        ClientSize = New Size(437, 363)
        Controls.Add(tbIntentosOmitidos)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(tbIntentosFallidos)
        Controls.Add(Label3)
        Controls.Add(tbIntentosExitosos)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbNumero)
        Controls.Add(lblHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Problema1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Programa 1 - ¿Qué número estoy pensando?"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents tbNumero As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbIntentosExitosos As TextBox
    Friend WithEvents tbIntentosFallidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tbIntentosOmitidos As TextBox
    Friend WithEvents Label4 As Label
End Class
