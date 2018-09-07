Imports System.IO
Module Module1

    Sub Main()
        Dim pathIn = My.Computer.FileSystem.SpecialDirectories.Desktop + "\keys.txt"
        Dim pathOut = My.Computer.FileSystem.SpecialDirectories.Desktop + "\keys_symmetry.txt"
        Dim introTextIn = "Please specify the path to the keys.txt (leave it blank for default path) : "
        Console.Out.WriteLine(introTextIn)
        Dim customPathIn = Console.ReadLine()
        If customPathIn <> "" Then pathIn = customPathIn
        Dim introTextOut = "Please specify the path to the keys_symmetry.txt (leave it blank for default path) : "
        Console.Out.WriteLine(introTextOut)
        Dim customPathOut = Console.ReadLine()
        If customPathOut <> "" Then pathOut = customPathOut

        Const blockSize = 1000
        Const keyLength = 27

        Dim rawKeys(blockSize) As String
        Dim indexIn = 0

        Dim sr As New StreamReader(pathIn)

        If Not File.Exists(pathIn) Then
            Console.WriteLine("No file found.")
        Else
            Do While sr.EndOfStream <> True
                rawKeys(indexIn) = sr.ReadLine
                If rawKeys(indexIn) <> "" Then
                    Console.WriteLine(rawKeys(indexIn))
                    indexIn += 1
                End If
            Loop
        End If

        Dim intKeys(blockSize, keyLength - 1) As Integer
        For i As Integer = 0 To indexIn - 1
            For j As Integer = 0 To keyLength - 10
                intKeys(i, j) = CInt(rawKeys(i).Substring(j, 1))
            Next
            For k As Integer = keyLength - 8 To keyLength
                intKeys(i, k - 1) = CInt(rawKeys(i).Substring(k, 1))
            Next
        Next

        Dim finalKeys(blockSize * 8, keyLength) As Integer
        Dim indexOut = 0
        For i As Integer = 0 To indexIn - 1
            For j As Integer = 0 To keyLength - 1
                finalKeys(indexOut, j) = intKeys(i, j)
            Next
            indexOut += 1

            finalKeys(indexOut, 0) = intKeys(i, 6)
            finalKeys(indexOut, 1) = intKeys(i, 3)
            finalKeys(indexOut, 2) = intKeys(i, 0)
            finalKeys(indexOut, 3) = intKeys(i, 7)
            finalKeys(indexOut, 4) = intKeys(i, 4)
            finalKeys(indexOut, 5) = intKeys(i, 1)
            finalKeys(indexOut, 6) = intKeys(i, 8)
            finalKeys(indexOut, 7) = intKeys(i, 5)
            finalKeys(indexOut, 8) = intKeys(i, 2)
            finalKeys(indexOut, 0 + 9) = intKeys(i, 6 + 9)
            finalKeys(indexOut, 1 + 9) = intKeys(i, 3 + 9)
            finalKeys(indexOut, 2 + 9) = intKeys(i, 0 + 9)
            finalKeys(indexOut, 3 + 9) = intKeys(i, 7 + 9)
            finalKeys(indexOut, 4 + 9) = intKeys(i, 4 + 9)
            finalKeys(indexOut, 5 + 9) = intKeys(i, 1 + 9)
            finalKeys(indexOut, 6 + 9) = intKeys(i, 8 + 9)
            finalKeys(indexOut, 7 + 9) = intKeys(i, 5 + 9)
            finalKeys(indexOut, 8 + 9) = intKeys(i, 2 + 9)
            finalKeys(indexOut, 0 + 18) = intKeys(i, 6 + 18)
            finalKeys(indexOut, 1 + 18) = intKeys(i, 3 + 18)
            finalKeys(indexOut, 2 + 18) = intKeys(i, 0 + 18)
            finalKeys(indexOut, 3 + 18) = intKeys(i, 7 + 18)
            finalKeys(indexOut, 4 + 18) = intKeys(i, 4 + 18)
            finalKeys(indexOut, 5 + 18) = intKeys(i, 1 + 18)
            finalKeys(indexOut, 6 + 18) = intKeys(i, 8 + 18)
            finalKeys(indexOut, 7 + 18) = intKeys(i, 5 + 18)
            finalKeys(indexOut, 8 + 18) = intKeys(i, 2 + 18)
            indexOut += 1

            finalKeys(indexOut, 0) = intKeys(i, 8)
            finalKeys(indexOut, 1) = intKeys(i, 7)
            finalKeys(indexOut, 2) = intKeys(i, 6)
            finalKeys(indexOut, 3) = intKeys(i, 5)
            finalKeys(indexOut, 4) = intKeys(i, 4)
            finalKeys(indexOut, 5) = intKeys(i, 3)
            finalKeys(indexOut, 6) = intKeys(i, 2)
            finalKeys(indexOut, 7) = intKeys(i, 1)
            finalKeys(indexOut, 8) = intKeys(i, 0)
            finalKeys(indexOut, 0 + 9) = intKeys(i, 8 + 9)
            finalKeys(indexOut, 1 + 9) = intKeys(i, 7 + 9)
            finalKeys(indexOut, 2 + 9) = intKeys(i, 6 + 9)
            finalKeys(indexOut, 3 + 9) = intKeys(i, 5 + 9)
            finalKeys(indexOut, 4 + 9) = intKeys(i, 4 + 9)
            finalKeys(indexOut, 5 + 9) = intKeys(i, 3 + 9)
            finalKeys(indexOut, 6 + 9) = intKeys(i, 2 + 9)
            finalKeys(indexOut, 7 + 9) = intKeys(i, 1 + 9)
            finalKeys(indexOut, 8 + 9) = intKeys(i, 0 + 9)
            finalKeys(indexOut, 0 + 18) = intKeys(i, 8 + 18)
            finalKeys(indexOut, 1 + 18) = intKeys(i, 7 + 18)
            finalKeys(indexOut, 2 + 18) = intKeys(i, 6 + 18)
            finalKeys(indexOut, 3 + 18) = intKeys(i, 5 + 18)
            finalKeys(indexOut, 4 + 18) = intKeys(i, 4 + 18)
            finalKeys(indexOut, 5 + 18) = intKeys(i, 3 + 18)
            finalKeys(indexOut, 6 + 18) = intKeys(i, 2 + 18)
            finalKeys(indexOut, 7 + 18) = intKeys(i, 1 + 18)
            finalKeys(indexOut, 8 + 18) = intKeys(i, 0 + 18)
            indexOut += 1

            finalKeys(indexOut, 0) = intKeys(i, 2)
            finalKeys(indexOut, 1) = intKeys(i, 5)
            finalKeys(indexOut, 2) = intKeys(i, 8)
            finalKeys(indexOut, 3) = intKeys(i, 1)
            finalKeys(indexOut, 4) = intKeys(i, 4)
            finalKeys(indexOut, 5) = intKeys(i, 7)
            finalKeys(indexOut, 6) = intKeys(i, 0)
            finalKeys(indexOut, 7) = intKeys(i, 3)
            finalKeys(indexOut, 8) = intKeys(i, 6)
            finalKeys(indexOut, 0 + 9) = intKeys(i, 2 + 9)
            finalKeys(indexOut, 1 + 9) = intKeys(i, 5 + 9)
            finalKeys(indexOut, 2 + 9) = intKeys(i, 8 + 9)
            finalKeys(indexOut, 3 + 9) = intKeys(i, 1 + 9)
            finalKeys(indexOut, 4 + 9) = intKeys(i, 4 + 9)
            finalKeys(indexOut, 5 + 9) = intKeys(i, 7 + 9)
            finalKeys(indexOut, 6 + 9) = intKeys(i, 0 + 9)
            finalKeys(indexOut, 7 + 9) = intKeys(i, 3 + 9)
            finalKeys(indexOut, 8 + 9) = intKeys(i, 6 + 9)
            finalKeys(indexOut, 0 + 18) = intKeys(i, 2 + 18)
            finalKeys(indexOut, 1 + 18) = intKeys(i, 5 + 18)
            finalKeys(indexOut, 2 + 18) = intKeys(i, 8 + 18)
            finalKeys(indexOut, 3 + 18) = intKeys(i, 1 + 18)
            finalKeys(indexOut, 4 + 18) = intKeys(i, 4 + 18)
            finalKeys(indexOut, 5 + 18) = intKeys(i, 7 + 18)
            finalKeys(indexOut, 6 + 18) = intKeys(i, 0 + 18)
            finalKeys(indexOut, 7 + 18) = intKeys(i, 3 + 18)
            finalKeys(indexOut, 8 + 18) = intKeys(i, 6 + 18)
            indexOut += 1

            finalKeys(indexOut, 0) = intKeys(i, 2)
            finalKeys(indexOut, 1) = intKeys(i, 1)
            finalKeys(indexOut, 2) = intKeys(i, 0)
            finalKeys(indexOut, 3) = intKeys(i, 5)
            finalKeys(indexOut, 4) = intKeys(i, 4)
            finalKeys(indexOut, 5) = intKeys(i, 3)
            finalKeys(indexOut, 6) = intKeys(i, 8)
            finalKeys(indexOut, 7) = intKeys(i, 7)
            finalKeys(indexOut, 8) = intKeys(i, 6)
            finalKeys(indexOut, 0 + 9) = intKeys(i, 2 + 9)
            finalKeys(indexOut, 1 + 9) = intKeys(i, 1 + 9)
            finalKeys(indexOut, 2 + 9) = intKeys(i, 0 + 9)
            finalKeys(indexOut, 3 + 9) = intKeys(i, 5 + 9)
            finalKeys(indexOut, 4 + 9) = intKeys(i, 4 + 9)
            finalKeys(indexOut, 5 + 9) = intKeys(i, 3 + 9)
            finalKeys(indexOut, 6 + 9) = intKeys(i, 8 + 9)
            finalKeys(indexOut, 7 + 9) = intKeys(i, 7 + 9)
            finalKeys(indexOut, 8 + 9) = intKeys(i, 6 + 9)
            finalKeys(indexOut, 0 + 18) = intKeys(i, 2 + 18)
            finalKeys(indexOut, 1 + 18) = intKeys(i, 1 + 18)
            finalKeys(indexOut, 2 + 18) = intKeys(i, 0 + 18)
            finalKeys(indexOut, 3 + 18) = intKeys(i, 5 + 18)
            finalKeys(indexOut, 4 + 18) = intKeys(i, 4 + 18)
            finalKeys(indexOut, 5 + 18) = intKeys(i, 3 + 18)
            finalKeys(indexOut, 6 + 18) = intKeys(i, 8 + 18)
            finalKeys(indexOut, 7 + 18) = intKeys(i, 7 + 18)
            finalKeys(indexOut, 8 + 18) = intKeys(i, 6 + 18)
            indexOut += 1

            finalKeys(indexOut, 0) = intKeys(i, 6)
            finalKeys(indexOut, 1) = intKeys(i, 7)
            finalKeys(indexOut, 2) = intKeys(i, 8)
            finalKeys(indexOut, 3) = intKeys(i, 3)
            finalKeys(indexOut, 4) = intKeys(i, 4)
            finalKeys(indexOut, 5) = intKeys(i, 5)
            finalKeys(indexOut, 6) = intKeys(i, 0)
            finalKeys(indexOut, 7) = intKeys(i, 1)
            finalKeys(indexOut, 8) = intKeys(i, 2)
            finalKeys(indexOut, 0 + 9) = intKeys(i, 6 + 9)
            finalKeys(indexOut, 1 + 9) = intKeys(i, 7 + 9)
            finalKeys(indexOut, 2 + 9) = intKeys(i, 8 + 9)
            finalKeys(indexOut, 3 + 9) = intKeys(i, 3 + 9)
            finalKeys(indexOut, 4 + 9) = intKeys(i, 4 + 9)
            finalKeys(indexOut, 5 + 9) = intKeys(i, 5 + 9)
            finalKeys(indexOut, 6 + 9) = intKeys(i, 0 + 9)
            finalKeys(indexOut, 7 + 9) = intKeys(i, 1 + 9)
            finalKeys(indexOut, 8 + 9) = intKeys(i, 2 + 9)
            finalKeys(indexOut, 0 + 18) = intKeys(i, 6 + 18)
            finalKeys(indexOut, 1 + 18) = intKeys(i, 7 + 18)
            finalKeys(indexOut, 2 + 18) = intKeys(i, 8 + 18)
            finalKeys(indexOut, 3 + 18) = intKeys(i, 3 + 18)
            finalKeys(indexOut, 4 + 18) = intKeys(i, 4 + 18)
            finalKeys(indexOut, 5 + 18) = intKeys(i, 5 + 18)
            finalKeys(indexOut, 6 + 18) = intKeys(i, 0 + 18)
            finalKeys(indexOut, 7 + 18) = intKeys(i, 1 + 18)
            finalKeys(indexOut, 8 + 18) = intKeys(i, 2 + 18)
            indexOut += 1

            finalKeys(indexOut, 0) = intKeys(i, 0)
            finalKeys(indexOut, 1) = intKeys(i, 3)
            finalKeys(indexOut, 2) = intKeys(i, 6)
            finalKeys(indexOut, 3) = intKeys(i, 1)
            finalKeys(indexOut, 4) = intKeys(i, 4)
            finalKeys(indexOut, 5) = intKeys(i, 7)
            finalKeys(indexOut, 6) = intKeys(i, 2)
            finalKeys(indexOut, 7) = intKeys(i, 5)
            finalKeys(indexOut, 8) = intKeys(i, 8)
            finalKeys(indexOut, 0 + 9) = intKeys(i, 0 + 9)
            finalKeys(indexOut, 1 + 9) = intKeys(i, 3 + 9)
            finalKeys(indexOut, 2 + 9) = intKeys(i, 6 + 9)
            finalKeys(indexOut, 3 + 9) = intKeys(i, 1 + 9)
            finalKeys(indexOut, 4 + 9) = intKeys(i, 4 + 9)
            finalKeys(indexOut, 5 + 9) = intKeys(i, 7 + 9)
            finalKeys(indexOut, 6 + 9) = intKeys(i, 2 + 9)
            finalKeys(indexOut, 7 + 9) = intKeys(i, 5 + 9)
            finalKeys(indexOut, 8 + 9) = intKeys(i, 8 + 9)
            finalKeys(indexOut, 0 + 18) = intKeys(i, 0 + 18)
            finalKeys(indexOut, 1 + 18) = intKeys(i, 3 + 18)
            finalKeys(indexOut, 2 + 18) = intKeys(i, 6 + 18)
            finalKeys(indexOut, 3 + 18) = intKeys(i, 1 + 18)
            finalKeys(indexOut, 4 + 18) = intKeys(i, 4 + 18)
            finalKeys(indexOut, 5 + 18) = intKeys(i, 7 + 18)
            finalKeys(indexOut, 6 + 18) = intKeys(i, 2 + 18)
            finalKeys(indexOut, 7 + 18) = intKeys(i, 5 + 18)
            finalKeys(indexOut, 8 + 18) = intKeys(i, 8 + 18)
            indexOut += 1

            finalKeys(indexOut, 0) = intKeys(i, 8)
            finalKeys(indexOut, 1) = intKeys(i, 5)
            finalKeys(indexOut, 2) = intKeys(i, 2)
            finalKeys(indexOut, 3) = intKeys(i, 7)
            finalKeys(indexOut, 4) = intKeys(i, 4)
            finalKeys(indexOut, 5) = intKeys(i, 1)
            finalKeys(indexOut, 6) = intKeys(i, 6)
            finalKeys(indexOut, 7) = intKeys(i, 3)
            finalKeys(indexOut, 8) = intKeys(i, 0)
            finalKeys(indexOut, 0 + 9) = intKeys(i, 8 + 9)
            finalKeys(indexOut, 1 + 9) = intKeys(i, 5 + 9)
            finalKeys(indexOut, 2 + 9) = intKeys(i, 2 + 9)
            finalKeys(indexOut, 3 + 9) = intKeys(i, 7 + 9)
            finalKeys(indexOut, 4 + 9) = intKeys(i, 4 + 9)
            finalKeys(indexOut, 5 + 9) = intKeys(i, 1 + 9)
            finalKeys(indexOut, 6 + 9) = intKeys(i, 6 + 9)
            finalKeys(indexOut, 7 + 9) = intKeys(i, 3 + 9)
            finalKeys(indexOut, 8 + 9) = intKeys(i, 0 + 9)
            finalKeys(indexOut, 0 + 18) = intKeys(i, 8 + 18)
            finalKeys(indexOut, 1 + 18) = intKeys(i, 5 + 18)
            finalKeys(indexOut, 2 + 18) = intKeys(i, 2 + 18)
            finalKeys(indexOut, 3 + 18) = intKeys(i, 7 + 18)
            finalKeys(indexOut, 4 + 18) = intKeys(i, 4 + 18)
            finalKeys(indexOut, 5 + 18) = intKeys(i, 1 + 18)
            finalKeys(indexOut, 6 + 18) = intKeys(i, 6 + 18)
            finalKeys(indexOut, 7 + 18) = intKeys(i, 3 + 18)
            finalKeys(indexOut, 8 + 18) = intKeys(i, 0 + 18)
            indexOut += 1

        Next

        Dim sw As StreamWriter
        Dim tempKey As String
        sw = My.Computer.FileSystem.OpenTextFileWriter(pathOut, True)
        For i As Integer = 0 To indexOut - 1
            tempKey = ""
            For j As Integer = 0 To keyLength - 1
                tempKey = tempKey & finalKeys(i, j)
            Next
            sw.WriteLine(tempKey)
        Next
        sw.Close()

        Console.ReadLine()

    End Sub

End Module
