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
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        tbNumero = New TextBox()
        lblHeader = New Label()
        Button2 = New Button()
        Button1 = New Button()
        ListView1 = New ListView()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(14, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 12
        Label2.Text = "Dígito 1"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(176, 73)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(193, 23)
        TextBox1.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(14, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 15)
        Label1.TabIndex = 10
        Label1.Text = "Dígito 2"
        ' 
        ' tbNumero
        ' 
        tbNumero.BackColor = Color.Black
        tbNumero.ForeColor = Color.White
        tbNumero.Location = New Point(176, 102)
        tbNumero.Name = "tbNumero"
        tbNumero.Size = New Size(193, 23)
        tbNumero.TabIndex = 9
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(12, 33)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(219, 25)
        lblHeader.TabIndex = 8
        lblHeader.Text = "Mínimo Común Múltiplo"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.ForeColor = Color.White
        Button2.Location = New Point(12, 385)
        Button2.Name = "Button2"
        Button2.Size = New Size(357, 33)
        Button2.TabIndex = 15
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.White
        Button1.Location = New Point(12, 346)
        Button1.Name = "Button1"
        Button1.Size = New Size(357, 33)
        Button1.TabIndex = 14
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.Black
        ListView1.ForeColor = SystemColors.Window
        ListView1.Location = New Point(12, 131)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(357, 209)
        ListView1.TabIndex = 13
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(386, 431)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListView1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(tbNumero)
        Controls.Add(lblHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Programa 3 - Mínimo Comun Multiplo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNumero As TextBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
End Class
