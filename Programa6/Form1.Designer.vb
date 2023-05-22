<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        tbIntentosOmitidos = New TextBox()
        Label4 = New Label()
        tbIntentosFallidos = New TextBox()
        Label3 = New Label()
        tbIntentosExitosos = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        cbTiempo = New ComboBox()
        cbDificultad = New ComboBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(12, 41)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(293, 25)
        lblHeader.TabIndex = 21
        lblHeader.Text = "Juego de operaciones aritméticas"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Desktop
        Button1.ForeColor = Color.White
        Button1.Location = New Point(12, 79)
        Button1.Name = "Button1"
        Button1.Size = New Size(273, 49)
        Button1.TabIndex = 22
        Button1.Text = "Suma"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.ForeColor = Color.White
        Button2.Location = New Point(12, 134)
        Button2.Name = "Button2"
        Button2.Size = New Size(273, 49)
        Button2.TabIndex = 23
        Button2.Text = "Resta"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Desktop
        Button3.ForeColor = Color.White
        Button3.Location = New Point(12, 189)
        Button3.Name = "Button3"
        Button3.Size = New Size(273, 49)
        Button3.TabIndex = 24
        Button3.Text = "Division"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.Desktop
        Button4.ForeColor = Color.White
        Button4.Location = New Point(12, 244)
        Button4.Name = "Button4"
        Button4.Size = New Size(273, 49)
        Button4.TabIndex = 25
        Button4.Text = "Multiplicacion"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.Desktop
        Button5.ForeColor = Color.White
        Button5.Location = New Point(12, 299)
        Button5.Name = "Button5"
        Button5.Size = New Size(273, 49)
        Button5.TabIndex = 26
        Button5.Text = "Residuo"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.Desktop
        Button6.ForeColor = Color.White
        Button6.Location = New Point(12, 354)
        Button6.Name = "Button6"
        Button6.Size = New Size(273, 49)
        Button6.TabIndex = 27
        Button6.Text = "Potencia"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' tbIntentosOmitidos
        ' 
        tbIntentosOmitidos.BackColor = Color.Black
        tbIntentosOmitidos.ForeColor = Color.White
        tbIntentosOmitidos.Location = New Point(303, 203)
        tbIntentosOmitidos.Name = "tbIntentosOmitidos"
        tbIntentosOmitidos.ReadOnly = True
        tbIntentosOmitidos.Size = New Size(235, 23)
        tbIntentosOmitidos.TabIndex = 33
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(303, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 32
        Label4.Text = "Intentos omitidos"
        ' 
        ' tbIntentosFallidos
        ' 
        tbIntentosFallidos.BackColor = Color.Black
        tbIntentosFallidos.ForeColor = Color.White
        tbIntentosFallidos.Location = New Point(303, 148)
        tbIntentosFallidos.Name = "tbIntentosFallidos"
        tbIntentosFallidos.ReadOnly = True
        tbIntentosFallidos.Size = New Size(235, 23)
        tbIntentosFallidos.TabIndex = 31
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(303, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 15)
        Label3.TabIndex = 30
        Label3.Text = "Intentos faliidos"
        ' 
        ' tbIntentosExitosos
        ' 
        tbIntentosExitosos.BackColor = Color.Black
        tbIntentosExitosos.ForeColor = Color.White
        tbIntentosExitosos.Location = New Point(303, 93)
        tbIntentosExitosos.Name = "tbIntentosExitosos"
        tbIntentosExitosos.ReadOnly = True
        tbIntentosExitosos.Size = New Size(235, 23)
        tbIntentosExitosos.TabIndex = 29
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(303, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 15)
        Label2.TabIndex = 28
        Label2.Text = "Intentos acertados"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(303, 358)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 34
        Label1.Text = "Tiempo"
        ' 
        ' cbTiempo
        ' 
        cbTiempo.DropDownStyle = ComboBoxStyle.DropDownList
        cbTiempo.FormattingEnabled = True
        cbTiempo.Items.AddRange(New Object() {"5", "10", "15", "20"})
        cbTiempo.Location = New Point(303, 376)
        cbTiempo.Name = "cbTiempo"
        cbTiempo.Size = New Size(235, 23)
        cbTiempo.TabIndex = 35
        ' 
        ' cbDificultad
        ' 
        cbDificultad.DropDownStyle = ComboBoxStyle.DropDownList
        cbDificultad.FormattingEnabled = True
        cbDificultad.Items.AddRange(New Object() {"Facil", "Medio", "Dificil"})
        cbDificultad.Location = New Point(303, 325)
        cbDificultad.Name = "cbDificultad"
        cbDificultad.Size = New Size(235, 23)
        cbDificultad.TabIndex = 37
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.ImageAlign = ContentAlignment.MiddleRight
        Label5.Location = New Point(303, 307)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 36
        Label5.Text = "Dificultad"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(557, 420)
        Controls.Add(cbDificultad)
        Controls.Add(Label5)
        Controls.Add(cbTiempo)
        Controls.Add(Label1)
        Controls.Add(tbIntentosOmitidos)
        Controls.Add(Label4)
        Controls.Add(tbIntentosFallidos)
        Controls.Add(Label3)
        Controls.Add(tbIntentosExitosos)
        Controls.Add(Label2)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lblHeader)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Problema 6 - Juego de operaciones aritméticas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents tbIntentosOmitidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbIntentosFallidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbIntentosExitosos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbTiempo As ComboBox
    Friend WithEvents cbDificultad As ComboBox
    Friend WithEvents Label5 As Label
End Class
