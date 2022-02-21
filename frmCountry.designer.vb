<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCountry
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
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

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.lstContinents = New System.Windows.Forms.ListBox()
    Me.lstCountries = New System.Windows.Forms.ListBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'lstContinents
    '
    Me.lstContinents.FormattingEnabled = True
    Me.lstContinents.Items.AddRange(New Object() {"Africa", "Antarctica", "Asia", "Australia/Oceania", "Europe", "North America", "South America"})
    Me.lstContinents.Location = New System.Drawing.Point(12, 48)
    Me.lstContinents.Name = "lstContinents"
    Me.lstContinents.Size = New System.Drawing.Size(95, 95)
    Me.lstContinents.TabIndex = 1
    '
    'lstCountries
    '
    Me.lstCountries.FormattingEnabled = True
    Me.lstCountries.Location = New System.Drawing.Point(132, 9)
    Me.lstCountries.Name = "lstCountries"
    Me.lstCountries.Size = New System.Drawing.Size(209, 134)
    Me.lstCountries.TabIndex = 2
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(13, 12)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(94, 29)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Click on the name of a continent:"
    '
    'frmCountry
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(353, 153)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lstCountries)
    Me.Controls.Add(Me.lstContinents)
    Me.Name = "frmCountry"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Display Countries by Continent"
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents lstContinents As System.Windows.Forms.ListBox
  Friend WithEvents lstCountries As System.Windows.Forms.ListBox
  Friend WithEvents Label1 As System.Windows.Forms.Label












End Class
