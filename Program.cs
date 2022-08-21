Console.WriteLine("Ingrese sus Ingresos en el primer semestre");  
double renta1 = double.Parse(Console.ReadLine());  

Console.WriteLine("Ingrese sus Ingresos en el segundo semestre");  
double renta2 = double.Parse(Console.ReadLine());  


double Total = renta1+renta2;  
string porimpues1 = "5%"; 
string porimpues2 = "10%"; 
string porimpues3 = "15%"; 
string porimpues4 = "20%"; 
string porimpues5 = "30%";   
double porcentaje = Total*0.05;
double porcentaje2 = Total*0.10;  
double porcentaje3 = Total*0.15;  
double porcentaje4 = Total*0.20;
double porcentaje5 = Total*0.30;       


 
 
if (Total<=10000) 
{  
if (Total<10000){  
    Console.WriteLine("Su renta anual es "+Total+" el total de renta a pagar es "+porcentaje+" el porcentaje de impuesto "+porimpues1);  
    Environment.Exit(0); 
} 
} 
if (Total>=10000){
if(Total>10000 && Total<20000){  
    Console.WriteLine("Su renta anual es "+Total+" el total de renta a pagar es "+porcentaje2+" el porcentaje de impuesto "+porimpues2);  
     Environment.Exit(0); 
} 
} 
if (Total>=20000){  
if(Total>20000 && Total<35000){  
    Console.WriteLine("Su renta anual es "+Total+" el total de renta a pagar es "+porcentaje3+" el porcentaje de impuesto "+porimpues3);  
     Environment.Exit(0); 
} 
} 
if (Total>=35000){  
if(Total>35000 && Total<45000){  
    Console.WriteLine("Su renta anual es "+Total+" el total de renta a pagar es "+porcentaje4+" el porcentaje de impuesto "+porimpues4);  
     Environment.Exit(0); 
} 
} 
if (Total>=45000){  
if(Total>45000 ){  
    Console.WriteLine("Su renta anual es "+Total+" el total de renta a pagar es "+porcentaje5+" el porcentaje de impuesto "+porimpues5);  
     Environment.Exit(0); 
} 
} 