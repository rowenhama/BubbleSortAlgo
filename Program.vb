Imports System


Module Module1

    Sub Main()
        Dim arr As Integer() = New Integer(5) {}
        Dim temp As Integer = 0

        Console.WriteLine("Enter array elements: ")
        For i = 0 To 4 Step 1
            Console.Write("Element[{0}]: ", i)
            arr(i) = Integer.Parse(Console.ReadLine())
        Next

        'Sort array using bubble sort.
        For i = 0 To 4 Step 1
            Dim j As Integer

            For j = 4 To i + 1 Step -1
                If (arr(j) < arr(j - 1)) Then
                    temp = arr(j)
                    arr(j) = arr(j - 1)
                    arr(j - 1) = temp
                End If
            Next
        Next

        Console.WriteLine("Array after sorting: ")
        For i = 0 To 4 Step 1
            Console.Write("{0} ", arr(i))
        Next
        Console.WriteLine()
    End Sub

End Module
