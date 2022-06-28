
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

/*
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for (int i = 0; i < copiaArray.Length; i++)
    {
        Console.Write((copiaArray[i] * copiaArray[i]) + ", ");
    }
}



//preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
//Stampare l’array di numeri fornito
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati

int[] defaultArray = { 2, 6, 7, 5, 3, 9 };

int sommaElementiArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        return array[i] += array[i];
    }
}

void StampaArrayNew(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

int[] ElevaArrayAlQuadratoNew(int[] array)
{
    int[] copiaDefaultArray = (int[])array.Clone();

    for (int i = 0; i < copiaDefaultArray.Length; i++)
    {
        Console.Write((copiaDefaultArray[i] * copiaDefaultArray[i]) + ", ");
    }
}

int[] ElevaArrayAlQuadratoNew(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for (int i = 0; i < copiaArray.Length; i++)
    {
        Console.Write((copiaArray[i] * copiaArray[i]) + ", ");
    }
}

*/