Public Class frmStudyMaterialsViewer

    Private _ThisMaterial As c_Material

    ''' <summary>
    ''' Constructor for Study Materials Viewer
    ''' </summary>
    ''' <param name="ThisMaterial">Material to view</param>
    ''' <remarks></remarks>
    Public Sub New(ByRef ThisMaterial As c_Material)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._ThisMaterial = ThisMaterial
    End Sub

    Private Sub frmStudyMaterialsViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .txtMaterialID.Text = _ThisMaterial.MaterialID
            .txtMaterialDescription.Text = _ThisMaterial.MaterialDescription
            .txtMaterialName.Text = _ThisMaterial.MaterialName
        End With
    End Sub
End Class