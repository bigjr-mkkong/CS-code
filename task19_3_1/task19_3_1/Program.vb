Module Program
	Sub array()
		Console.WriteLine("a kind of data structure which store the data in series and allow user to access them randomly")
	End Sub	
	Sub filehandel()
		Console.WriteLine("when your program send out a request to access a file in your computer to a system function, that function will return a number")
		Console.WriteLine("and this number is the only identifire to the file which you want to access, this number is the file handle")
		Console.WriteLine("one process can only have one handle, so remember to close the old handle when you want ot use a new handle")
	End Sub
	Sub subrot()
		Console.WriteLine("subroutines is a set of code which user need to execute them for many times")
		Console.WriteLine("choose to use sunroutines can make your program more readable and reliable")
	End Sub
	Sub Func()
		Console.WriteLine("function is a set of code, which computer exectue them and get a result")
		Console.WriteLine("subroutines will copy in to your main code after compile, but function will just embeded in your program")
		Console.WriteLine("when computer call he function, system will allocate a stack space to store the parameter, and jump to the address of the functiob")
		Console.WriteLine("so the variables inside the function will not conflict with them in main subroutines")
	End Sub
	Sub Main()
		Dim input As String="xxx"
		While Not input=""
			Console.Clear()
			Console.WriteLine("choose what you want to now" &vbCrLf &"1. 1d array" &vbCrLf &"2. file handeling" & vbCrLf &"3. subroutines" & vbCrLf & "4. function" & vbCrLf & "5. exit")
			input=Console.ReadLine()
			If input="1" Then
				array()
			Else If input="2" Then
				filehandel()
			Else If input="3" Then
				subrot()
			Else If input="4" Then
				Func()
			Else If input="5" Then
				Exit Sub
			Else
				Console.WriteLine("we do not have this choice")
			End If
			Console.ReadKey()
		End While
		Console.ReadKey(True)
	End Sub
End Module
