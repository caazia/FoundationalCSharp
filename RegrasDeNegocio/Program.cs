Random random = new Random();
int daysUntilExpiration = random.Next(12);
//int discountPercentage = 0;

/*
Regra 2: se a assinatura do usuário expirar em dez dias ou menos, será exibida a mensagem
Regra 3: se a assinatura do usuário expirar em cinco dias ou menos, será exibida a mensagem:
Regra 4: se a assinatura do usuário expirar em um dia, serão exibidas as mensagens:
Regra 5: se a assinatura do usuário tiver expirado, será exibida a mensagem:
6: se a assinatura do usuário não expirar em dez dias ou menos, não será exibida nenhuma mensagem.
*/
if(daysUntilExpiration > 10)
{
    Console.WriteLine();
}
else if (daysUntilExpiration > 5)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration > 1)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
}
else 
{
    Console.WriteLine("Your subscription has expired.");
}