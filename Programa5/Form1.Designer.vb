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
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        tbIntentosFallidos = New TextBox()
        Label3 = New Label()
        tbIntentosExitosos = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(12, 30)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(368, 25)
        lblHeader.TabIndex = 20
        lblHeader.Text = "Responde el resultado de la suma correcta"
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.Desktop
        Button4.ForeColor = Color.White
        Button4.Location = New Point(303, 124)
        Button4.Name = "Button4"
        Button4.Size = New Size(91, 92)
        Button4.TabIndex = 19
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Desktop
        Button3.ForeColor = Color.White
        Button3.Location = New Point(206, 124)
        Button3.Name = "Button3"
        Button3.Size = New Size(91, 92)
        Button3.TabIndex = 18
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.ForeColor = Color.White
        Button2.Location = New Point(109, 124)
        Button2.Name = "Button2"
        Button2.Size = New Size(91, 92)
        Button2.TabIndex = 17
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Desktop
        Button1.ForeColor = Color.White
        Button1.Location = New Point(12, 124)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 92)
        Button1.TabIndex = 16
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' tbIntentosFallidos
        ' 
        tbIntentosFallidos.BackColor = Color.Black
        tbIntentosFallidos.ForeColor = Color.White
        tbIntentosFallidos.Location = New Point(14, 289)
        tbIntentosFallidos.Name = "tbIntentosFallidos"
        tbIntentosFallidos.ReadOnly = True
        tbIntentosFallidos.Size = New Size(382, 23)
        tbIntentosFallidos.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(14, 271)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 15)
        Label3.TabIndex = 23
        Label3.Text = "Intentos faliidos"
        ' 
        ' tbIntentosExitosos
        ' 
        tbIntentosExitosos.BackColor = Color.Black
        tbIntentosExitosos.ForeColor = Color.White
        tbIntentosExitosos.Location = New Point(14, 244)
        tbIntentosExitosos.Name = "tbIntentosExitosos"
        tbIntentosExitosos.ReadOnly = True
        tbIntentosExitosos.Size = New Size(382, 23)
        tbIntentosExitosos.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(13, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 15)
        Label2.TabIndex = 21
        Label2.Text = "Intentos acertados"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 21)
        Label1.TabIndex = 25
        Label1.Text = "Pregunta"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(408, 328)
        Controls.Add(Label1)
        Controls.Add(tbIntentosFallidos)
        Controls.Add(Label3)
        Controls.Add(tbIntentosExitosos)
        Controls.Add(Label2)
        Controls.Add(lblHeader)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Programa5 - Responde el resultado de la suma correcta"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tbIntentosFallidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbIntentosExitosos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
