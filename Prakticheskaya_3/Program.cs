using System;

class Program
{
    static void Main()
    {
        int currentOctave = 1; // Изначально выбрана первая октава

        Console.WriteLine("Для воспроизведения нот A - J клавиши, F5 и F6 для переключения октав, Escape - выход");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            ConsoleKey key = keyInfo.Key;
            if (key == ConsoleKey.Escape)
            {
                break;
            }
            else if (key == ConsoleKey.F5)
            {
                currentOctave = 1;
                Console.WriteLine("Переключено на первую октаву");
            }
            else if (key == ConsoleKey.F6)
            {
                currentOctave = 2;
                Console.WriteLine("Переключено на вторую октаву");
            }
            else
            {
                int noteIndex = Array.IndexOf(notes, key);
                if (noteIndex != -1)
                {
                    int frequency = currentOctave == 1 ? octave1[noteIndex] : octave2[noteIndex];
                    Console.Beep(frequency, 200);
                }
            }
        }
    }

    static ConsoleKey[] notes = { ConsoleKey.A, ConsoleKey.S, ConsoleKey.D, ConsoleKey.F, ConsoleKey.G, ConsoleKey.H, ConsoleKey.J };
    static int[] octave1 = { 261, 293, 329, 349, 392, 440, 493 };
    static int[] octave2 = { 523, 587, 659, 698, 784, 880, 987 };
}
