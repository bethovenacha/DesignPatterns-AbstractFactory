Providing an interface for creating families of related or dependent objects without specifying their concrete classes. <br>

Factory for other factories. <br>

To use this in your main program:  Instantiate CreditUnionFactoryProvider to provide you with the right type of factory depending on the account number passed.<br>

ICreditUnionFactory abstractFactory = new CreditUnionFactoryProvider("ACCOUNTNUMBER-CITY");<br>

if(abstractFactory == null){<br>
     console.writeline("INVALID ACCOUNT NUMBER");<br>
}<br>
else{<br>
   ILoan loan = abstractFactory.CreateLoan(); <br>
   ISavings savings = abstractFactory.CreateSavings(): <br>
}
