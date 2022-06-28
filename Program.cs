
//preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. 

Console.WriteLine("Quanti elementi vuoi inserire nel tuo array?");
int nUser = int.Parse(Console.ReadLine());
int[] arrayUser = new int[nUser];

for (int i = 0; i < nUser; i++)
{
    Console.WriteLine($"Dammi l'elemento {i} dell'array");
    arrayUser[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("");

void StampaArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

StampaArray(arrayUser);



// vi restituisca il quadrato del numero passato come parametro.

int Quadrato(int numero)
{
    return numero * numero;
}



//preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = Quadrato(array[i]);
    }

    return copiaArray;
}



//preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
//Stampare l’array di numeri fornito
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati

int[] defaultArray = { 2, 6, 7, 5, 3, 9 };

int sommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    return somma;
}

void StampaArrayNew(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

/*
int[] ElevaArrayAlQuadratoNew(int[] array)
{
    int[] copiaDefaultArray = (int[])array.Clone();

    for (int i = 0; i < copiaDefaultArray.Length; i++)
    {
        Console.Write((copiaDefaultArray[i] * copiaDefaultArray[i]) + ", ");
    }
}

int sommaElementiArrayNew(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int sommaElementi =+ array[i];
        return sommaElementi;
    }
}

int sommaElementiArrayQuadratoNew(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int sumElements =+ array[i];
        int squareTotalElements = sumElements*sumElements;
        return squareTotalElements;
    }

}
*/



//Creazione parola palindroma utilizzando 2 array

string parola = Console.ReadLine();
char[] palindroma = new char[parola.Length];

for (int i = 0; i < parola.Length; i++)
{
    palindroma[i] = parola[(parola.Length-1)-i];
}

bool parolaPalindroma = true;

for (int i = 0; i < parola.Length; i++)
{
    if(parola[i] == palindroma[i])
    {
        parolaPalindroma = false;
        break; // i = parola.length;
    }
}

if(parolaPalindroma)
{
    Console.Write("La parola è palindroma");
}
else
{
    Console.Write("La parola non è palindroma");
}

return;