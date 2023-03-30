Module MainModule

  ' I am now changing MainModule.vb
  ' These changes are being made on 03/30/23 at 8:09 PM
  ' I hope that I can same them to the repo AOK.  


  Dim Name As String = "Mountain Bike"

  Sub Main()
    'Dim ProductID As Integer
    'Dim isActive As Boolean
    'Dim Name As String
    'Dim ListPrice As Decimal
    'Dim SellStartDate As DateTime

    'ProductID = 1
    'isActive = True
    'Name = "10 Speed Bike"
    'ListPrice = 999.99D
    'SellStartDate = #1/1/2019#

    'Dim Name As String = "10 Speed Bike"

    'If True Then
    '  Dim Name As String = "Tricycle"
    '  Dim ListPrice As Decimal = 59.99D
    'End If

    'Console.WriteLine(Name)
    'Console.WriteLine(listprice)

    'IncrementListPrice()
    'IncrementListPrice()
    'IncrementListPrice()

    Dim s1 As Object
    Dim s2 As Object

    s1 = "1"
    s2 = 2
    Console.WriteLine(s1 + s2)

    s2 = "2"
    Console.WriteLine(s1 + s2)



    'theData = "10 Speed Bike"
    'Console.WriteLine(theData)

    'theData = 999.99
    'Console.WriteLine(theData)

    'theData = DateTime.Now
    'Console.WriteLine(theData)

    'theData = vbEmpty
    'Console.WriteLine(theData)

    'theData = DBNull.Value
    'Console.WriteLine(theData)

    Console.ReadKey()

  End Sub

  Sub IncrementListPrice()
    Static ListPrice As Decimal = 0

    ListPrice = ListPrice + 1

    Console.WriteLine(ListPrice)

  End Sub

  Sub Main1()

    Console.WriteLine(Name)
  End Sub

  Sub Main2()
    Console.WriteLine(Name)
  End Sub

End Module
