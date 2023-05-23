<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblHeader = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 21)
        Label1.TabIndex = 31
        Label1.Text = "Pregunta"
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(16, 30)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(338, 25)
        lblHeader.TabIndex = 30
        lblHeader.Text = "Responde el resultado de la operación."
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.Desktop
        Button4.ForeColor = Color.White
        Button4.Location = New Point(231, 220)
        Button4.Name = "Button4"
        Button4.Size = New Size(209, 92)
        Button4.TabIndex = 29
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Desktop
        Button3.ForeColor = Color.White
        Button3.Location = New Point(231, 123)
        Button3.Name = "Button3"
        Button3.Size = New Size(209, 92)
        Button3.TabIndex = 28
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.ForeColor = Color.White
        Button2.Location = New Point(16, 220)
        Button2.Name = "Button2"
        Button2.Size = New Size(209, 92)
        Button2.TabIndex = 27
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Desktop
        Button1.ForeColor = Color.White
        Button1.Location = New Point(16, 123)
        Button1.Name = "Button1"
        Button1.Size = New Size(209, 92)
        Button1.TabIndex = 26
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(459, 324)
        Controls.Add(Label1)
        Controls.Add(lblHeader)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
