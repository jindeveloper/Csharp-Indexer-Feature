Imports CSharpIndexFeatureExplore
Imports CSharpIndexFeatureExplore.Models

Module Module1

    Sub Main()
        Dim fruits As New Food()


        Dim myCollectionOfFruits = fruits.FoodPyramid(1)

        For Each item As String In myCollectionOfFruits
            Console.WriteLine(item)
        Next




    End Sub

End Module
