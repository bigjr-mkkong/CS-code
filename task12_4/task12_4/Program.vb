Module Program
	Sub Main()
		Dim in1 As Integer
		While 1<2
		Console.WriteLine("Please select a topic from below to learn more about:")
		Console.WriteLine("1. Varibles")
		Console.WriteLine("2. IF Statement")
		Console.WriteLine("3. CASE Statement")
		Console.WriteLine("4. Count Controlled Loops")
		Console.WriteLine("5. Pre-Condition Loops")
		Console.WriteLine("6. Post-Condition Loops")
		Console.WriteLine("99. Exit")
		In1=Console.ReadLine()
		Console.Clear()
		Select Case in1
                Case = 1
                    Console.WriteLine("dim [var1] as [type]")
                Case = 2
                    Console.WriteLine("if [condition] then [statemrnt]" & vbCrLf & "else if [condition] then [statement]" & vbCrLf & "endif")
                Case = 3
                    Console.WriteLine("select case [var1]" & vbCrLf & "case=[condition] [statement]" & vbCrLf & "scase=[condition] [statement]" & vbCrLf & " end select")
                Case = 4
                    Console.WriteLine("for [define loop var] step[step length]" & vbCrLf & "next [loop var]")
                Case = 5
                    Console.WriteLine("while [condition] then [statement]" & vbCrLf & "end while")
                Case = 6
                'post-condition loops
                Case =99
                    Exit Sub
                Case Else
                    Console.WriteLine("no option supported, please enter twice time")
		End Select
		Console.ReadLine()
		Console.Clear()
        End While
        Console.ReadKey(True)
	End Sub
End Module
