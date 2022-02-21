Public Class frmCountry

  Structure Nation
    Dim name As String
    Dim continent As String
    Dim population As Double  'in millions
    Dim area As Double        'in square miles
  End Structure

  Dim nations(192) As Nation

  Private Sub frmCountry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    'Place the contents of UN.txt into the array nations
    Dim line As String
    Dim data(3) As String
    Dim countries() As String = IO.File.ReadAllLines("UN.txt")
    For i As Integer = 0 To 192
      line = countries(i)
      data = line.Split(","c)
      nations(i).name = data(0)
      nations(i).continent = data(1)
      nations(i).population = CDbl(data(2))
      nations(i).area = CDbl(data(3))
    Next
  End Sub

  Private Sub lstContinents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles _
                                 lstContinents.SelectedIndexChanged
    Dim selectedContinent As String = lstContinents.Text
    lstCountries.Items.Clear()
    If selectedContinent = "Antarctica" Then
      MessageBox.Show("There are no countries in Antarctica.")
    Else
      For i As Integer = 0 To 192
        If nations(i).continent = selectedContinent Then
          lstCountries.Items.Add(nations(i).name)
        End If
      Next
    End If
  End Sub

End Class
