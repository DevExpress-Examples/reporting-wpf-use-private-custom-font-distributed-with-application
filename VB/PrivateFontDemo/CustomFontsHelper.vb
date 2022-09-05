Imports System.Drawing
Imports System.Drawing.Text
Imports System.Linq

Namespace PrivateFontDemo

    Public Module CustomFontsHelper

        Private fontCollectionField As PrivateFontCollection

        Public ReadOnly Property FontCollection As FontCollection
            Get
                If fontCollectionField Is Nothing Then
                    fontCollectionField = New PrivateFontCollection()
                    fontCollectionField.AddFontFile("./Fonts/MissFajardose-Regular.ttf")
                End If

                Return fontCollectionField
            End Get
        End Property

        Public Function GetFamily(ByVal familyName As String) As FontFamily
            Return FontCollection.Families.FirstOrDefault(Function(ff) Equals(ff.Name, familyName))
        End Function
    End Module
End Namespace
