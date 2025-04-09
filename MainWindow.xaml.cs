using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BinaryTasks
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeTasks();
        }

        private void InitializeTasks()
        {
            for (int i = 1; i <= 30; i++)
            {
                TaskComboBox.Items.Add($"Задача {i}");
            }
            TaskComboBox.SelectedIndex = 0;
        }

        private void TaskComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InputPanel.Children.Clear();
            ResultText.Text = "";

            int taskNumber = TaskComboBox.SelectedIndex + 1;

            switch (taskNumber)
            {
                case 1:
                case 2:
                case 3:
                case 13:
                case 17:
                case 29:
                    AddBinaryInput();
                    break;
                case 4:
                case 5:
                case 6:
                    AddFractionalBinaryInput();
                    break;
                case 7:
                    AddArrayInput(15, "двузначных целых чисел");
                    break;
                case 8:
                    AddArrayInput(9, "двузначных восьмеричных чисел");
                    break;
                case 9:
                    AddArrayInput(7, "двузначных чисел");
                    break;
                case 10:
                    AddTwoArraysInput();
                    break;
                case 11:
                    AddArrayInput(12, "двоичных чисел");
                    break;
                case 12:
                    AddArrayInputWithTwoDuplicates();
                    break;
                case 14:
                case 15:
                case 16:
                case 23:
                case 24:
                case 25:
                case 26:
                case 28:
                    AddBinaryArrayInput();
                    break;
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                    AddIntegerArrayInput();
                    break;
                case 27:
                    AddRealArrayAndNumberInput();
                    break;
                case 30:
                    AddArrayInput(3, "десятичных чисел");
                    break;
            }
        }

        private void AddBinaryInput()
        {
            InputPanel.Children.Add(new TextBlock { Text = "Введите двоичное число:", Margin = new Thickness(0, 0, 0, 5) });
            InputPanel.Children.Add(new TextBox { Name = "BinaryInput", FontSize = 14, Margin = new Thickness(0, 0, 0, 10) });
        }

        private void AddFractionalBinaryInput()
        {
            InputPanel.Children.Add(new TextBlock { Text = "Введите дробное двоичное число (с точкой):", Margin = new Thickness(0, 0, 0, 5) });
            InputPanel.Children.Add(new TextBox { Name = "FractionalBinaryInput", FontSize = 14, Margin = new Thickness(0, 0, 0, 10) });
        }

        private void AddArrayInput(int count, string description)
        {
            InputPanel.Children.Add(new TextBlock { Text = $"Введите {count} {description} (через пробел):", Margin = new Thickness(0, 0, 0, 5) });
            InputPanel.Children.Add(new TextBox { Name = "ArrayInput", FontSize = 14, Margin = new Thickness(0, 0, 0, 10) });
        }

        private void AddTwoArraysInput()
        {
            InputPanel.Children.Add(new TextBlock { Text = "Введите первый массив из 7 действительных чисел (через пробел):", Margin = new Thickness(0, 0, 0, 5) });
            InputPanel.Children.Add(new TextBox { Name = "FirstArrayInput", FontSize = 14, Margin = new Thickness(0, 0, 0, 10) });
            InputPanel.Children.Add(new TextBlock { Text = "Введите второй массив из 9 действительных чисел (через пробел):", Margin = new Thickness(0, 0, 0, 5) });
            InputPanel.Children.Add(new TextBox { Name = "SecondArrayInput", FontSize = 14, Margin = new Thickness(0, 0, 0, 10) });
        }

        private void AddArrayInputWithTwoDuplicates()
        {
            InputPanel.Children.Add(new TextBlock { Text = "Введите массив, в котором только два одинаковых элемента (через пробел):", Margin = new Thickness(0, 0, 0, 5) });
            InputPanel.Children.Add(new TextBox { Name = "ArrayInput", FontSize = 14, Margin = new Thickness(0, 0, 0, 10) });
        }

        private void AddBinaryArrayInput()
        {
            InputPanel.Children.Add(new TextBlock { Text = "Введите массив двоичных чисел (через пробел):", Margin = new Thickness(0, 0, 0, 5) });
            InputPanel.Children.Add(new TextBox { Name = "BinaryArrayInput", FontSize = 14, Margin = new Thickness(0, 0, 0, 10) });
        }

        private void AddIntegerArrayInput()
        {
            InputPanel.Children.Add(new TextBlock { Text = "Введите целочисленный массив (через пробел):", Margin = new Thickness(0, 0, 0, 5) });
            InputPanel.Children.Add(new TextBox { Name = "IntegerArrayInput", FontSize = 14, Margin = new Thickness(0, 0, 0, 10) });
        }

        private void AddRealArrayAndNumberInput()
        {
            InputPanel.Children.Add(new TextBlock { Text = "Введите массив вещественных чисел (через пробел):", Margin = new Thickness(0, 0, 0, 5) });
            InputPanel.Children.Add(new TextBox { Name = "RealArrayInput", FontSize = 14, Margin = new Thickness(0, 0, 0, 10) });
            InputPanel.Children.Add(new TextBlock { Text = "Введите число R:", Margin = new Thickness(0, 10, 0, 5) });
            InputPanel.Children.Add(new TextBox { Name = "NumberInput", FontSize = 14, Margin = new Thickness(0, 0, 0, 10) });
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            int taskNumber = TaskComboBox.SelectedIndex + 1;
            string result = "";

            try
            {
                switch (taskNumber)
                {
                    case 1:
                        result = SolveTask1();
                        break;
                    case 2:
                        result = SolveTask2();
                        break;
                    case 3:
                        result = SolveTask3();
                        break;
                    case 4:
                        result = SolveTask4();
                        break;
                    case 5:
                        result = SolveTask5();
                        break;
                    case 6:
                        result = SolveTask6();
                        break;
                    case 7:
                        result = SolveTask7();
                        break;
                    case 8:
                        result = SolveTask8();
                        break;
                    case 9:
                        result = SolveTask9();
                        break;
                    case 10:
                        result = SolveTask10();
                        break;
                    case 11:
                        result = SolveTask11();
                        break;
                    case 12:
                        result = SolveTask12();
                        break;
                    case 13:
                        result = SolveTask13();
                        break;
                    case 14:
                        result = SolveTask14();
                        break;
                    case 15:
                        result = SolveTask15();
                        break;
                    case 16:
                        result = SolveTask16();
                        break;
                    case 17:
                        result = SolveTask17();
                        break;
                    case 18:
                        result = SolveTask18();
                        break;
                    case 19:
                        result = SolveTask19();
                        break;
                    case 20:
                        result = SolveTask20();
                        break;
                    case 21:
                        result = SolveTask21();
                        break;
                    case 22:
                        result = SolveTask22();
                        break;
                    case 23:
                        result = SolveTask23();
                        break;
                    case 24:
                        result = SolveTask24();
                        break;
                    case 25:
                        result = SolveTask25();
                        break;
                    case 26:
                        result = SolveTask26();
                        break;
                    case 27:
                        result = SolveTask27();
                        break;
                    case 28:
                        result = SolveTask28();
                        break;
                    case 29:
                        result = SolveTask29();
                        break;
                    case 30:
                        result = SolveTask30();
                        break;
                }
            }
            catch (Exception ex)
            {
                result = $"Ошибка: {ex.Message}";
            }

            ResultText.Text = result;
        }

        private string SolveTask1()
        {
            string binary = ((TextBox)InputPanel.Children[1]).Text;
            if (!IsBinary(binary)) throw new ArgumentException("Введено не двоичное число");
            int decimalNumber = Convert.ToInt32(binary, 2);
            return $"Десятичное представление: {decimalNumber}";
        }

        private string SolveTask2()
        {
            string binary = ((TextBox)InputPanel.Children[1]).Text;
            if (!IsBinary(binary)) throw new ArgumentException("Введено не двоичное число");

            // Дополняем нулями слева до длины, кратной 3
            while (binary.Length % 3 != 0)
            {
                binary = "0" + binary;
            }

            StringBuilder octal = new StringBuilder();
            for (int i = 0; i < binary.Length; i += 3)
            {
                string triplet = binary.Substring(i, 3);
                int value = Convert.ToInt32(triplet, 2);
                octal.Append(value);
            }

            return $"Восьмеричное представление: {octal.ToString()}";
        }

        private string SolveTask3()
        {
            string binary = ((TextBox)InputPanel.Children[1]).Text;
            if (!IsBinary(binary)) throw new ArgumentException("Введено не двоичное число");

            // Дополняем нулями слева до длины, кратной 4
            while (binary.Length % 4 != 0)
            {
                binary = "0" + binary;
            }

            StringBuilder hex = new StringBuilder();
            for (int i = 0; i < binary.Length; i += 4)
            {
                string quartet = binary.Substring(i, 4);
                int value = Convert.ToInt32(quartet, 2);
                hex.Append(value.ToString("X"));
            }

            return $"Шестнадцатеричное представление: {hex.ToString()}";
        }

        private string SolveTask4()
        {
            string binaryFraction = ((TextBox)InputPanel.Children[1]).Text;
            if (!IsFractionalBinary(binaryFraction)) throw new ArgumentException("Введено не дробное двоичное число");

            string[] parts = binaryFraction.Split('.');
            string integerPart = parts[0];
            string fractionalPart = parts.Length > 1 ? parts[1] : "";

            // Преобразование целой части
            int integerValue = integerPart == "" ? 0 : Convert.ToInt32(integerPart, 2);

            // Преобразование дробной части
            double fractionalValue = 0.0;
            for (int i = 0; i < fractionalPart.Length; i++)
            {
                if (fractionalPart[i] == '1')
                {
                    fractionalValue += Math.Pow(2, -(i + 1));
                }
            }

            double result = integerValue + fractionalValue;
            return $"Десятичное представление: {result}";
        }

        private string SolveTask5()
        {
            string binaryFraction = ((TextBox)InputPanel.Children[1]).Text;
            if (!IsFractionalBinary(binaryFraction)) throw new ArgumentException("Введено не дробное двоичное число");

            string[] parts = binaryFraction.Split('.');
            string integerPart = parts[0];
            string fractionalPart = parts.Length > 1 ? parts[1] : "";

            // Преобразование целой части в восьмеричную
            string octalInteger = "";
            if (integerPart != "")
            {
                // Дополняем нулями слева до длины, кратной 3
                while (integerPart.Length % 3 != 0)
                {
                    integerPart = "0" + integerPart;
                }

                for (int i = 0; i < integerPart.Length; i += 3)
                {
                    string triplet = integerPart.Substring(i, 3);
                    int value = Convert.ToInt32(triplet, 2);
                    octalInteger += value;
                }
            }
            else
            {
                octalInteger = "0";
            }

            // Преобразование дробной части в восьмеричную
            string octalFraction = "";
            if (fractionalPart != "")
            {
                // Дополняем нулями справа до длины, кратной 3
                while (fractionalPart.Length % 3 != 0)
                {
                    fractionalPart += "0";
                }

                for (int i = 0; i < fractionalPart.Length; i += 3)
                {
                    string triplet = fractionalPart.Substring(i, 3);
                    int value = Convert.ToInt32(triplet, 2);
                    octalFraction += value;
                }
            }

            string result = octalInteger;
            if (octalFraction != "") result += "." + octalFraction;
            return $"Восьмеричное представление: {result}";
        }

        private string SolveTask6()
        {
            string binaryFraction = ((TextBox)InputPanel.Children[1]).Text;
            if (!IsFractionalBinary(binaryFraction)) throw new ArgumentException("Введено не дробное двоичное число");

            string[] parts = binaryFraction.Split('.');
            string integerPart = parts[0];
            string fractionalPart = parts.Length > 1 ? parts[1] : "";

            // Преобразование целой части в шестнадцатеричную
            string hexInteger = "";
            if (integerPart != "")
            {
                // Дополняем нулями слева до длины, кратной 4
                while (integerPart.Length % 4 != 0)
                {
                    integerPart = "0" + integerPart;
                }

                for (int i = 0; i < integerPart.Length; i += 4)
                {
                    string quartet = integerPart.Substring(i, 4);
                    int value = Convert.ToInt32(quartet, 2);
                    hexInteger += value.ToString("X");
                }
            }
            else
            {
                hexInteger = "0";
            }

            // Преобразование дробной части в шестнадцатеричную
            string hexFraction = "";
            if (fractionalPart != "")
            {
                // Дополняем нулями справа до длины, кратной 4
                while (fractionalPart.Length % 4 != 0)
                {
                    fractionalPart += "0";
                }

                for (int i = 0; i < fractionalPart.Length; i += 4)
                {
                    string quartet = fractionalPart.Substring(i, 4);
                    int value = Convert.ToInt32(quartet, 2);
                    hexFraction += value.ToString("X");
                }
            }

            string result = hexInteger;
            if (hexFraction != "") result += "." + hexFraction;
            return $"Шестнадцатеричное представление: {result}";
        }

        private string SolveTask7()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 15) throw new ArgumentException("Введите ровно 15 двузначных чисел");

            List<int> originalArray = new List<int>();
            foreach (string num in numbers)
            {
                if (!int.TryParse(num, out int n) || n < 10 || n > 99)
                    throw new ArgumentException("Все числа должны быть двузначными");
                originalArray.Add(n);
            }

            List<int> newArray = new List<int>();
            foreach (int num in originalArray)
            {
                int tens = num / 10;
                int units = num % 10;
                newArray.Add(units * 10 + tens);
            }

            return $"Новый массив: {string.Join(" ", newArray)}";
        }

        private string SolveTask8()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 9) throw new ArgumentException("Введите ровно 9 двузначных восьмеричных чисел");

            List<int> decimalArray = new List<int>();
            foreach (string num in numbers)
            {
                if (num.Length != 2 || !IsOctal(num))
                    throw new ArgumentException("Все числа должны быть двузначными восьмеричными");
                decimalArray.Add(Convert.ToInt32(num, 8));
            }

            return $"Десятичный массив: {string.Join(" ", decimalArray)}";
        }

        private string SolveTask9()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 7) throw new ArgumentException("Введите ровно 7 двузначных чисел");

            List<int> originalArray = new List<int>();
            foreach (string num in numbers)
            {
                if (!int.TryParse(num, out int n) || n < 10 || n > 99)
                    throw new ArgumentException("Все числа должны быть двузначными");
                originalArray.Add(n);
            }

            List<int> newArray = new List<int>();
            foreach (int num in originalArray)
            {
                newArray.Add(num / 10);
            }

            return $"Новый массив (старшие разряды): {string.Join(" ", newArray)}";
        }

        private string SolveTask10()
        {
            string firstInput = ((TextBox)InputPanel.Children[1]).Text;
            string secondInput = ((TextBox)InputPanel.Children[3]).Text;

            string[] firstNumbers = firstInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondNumbers = secondInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (firstNumbers.Length != 7) throw new ArgumentException("Первый массив должен содержать 7 чисел");
            if (secondNumbers.Length != 9) throw new ArgumentException("Второй массив должен содержать 9 чисел");

            List<double> combined = new List<double>();
            foreach (string num in firstNumbers)
            {
                if (!double.TryParse(num, out double n))
                    throw new ArgumentException("Все элементы должны быть действительными числами");
                combined.Add(n);
            }
            foreach (string num in secondNumbers)
            {
                if (!double.TryParse(num, out double n))
                    throw new ArgumentException("Все элементы должны быть действительными числами");
                combined.Add(n);
            }

            combined.Sort((a, b) => b.CompareTo(a)); // Сортировка по убыванию

            return $"Объединенный и отсортированный массив: {string.Join(" ", combined)}";
        }

        private string SolveTask11()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 12) throw new ArgumentException("Введите ровно 12 двоичных чисел");

            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (string num in numbers)
            {
                if (!IsBinary(num)) throw new ArgumentException("Все числа должны быть двоичными");
                if (count.ContainsKey(num))
                    count[num]++;
                else
                    count[num] = 1;
            }

            List<string> result = new List<string>();
            foreach (string num in numbers)
            {
                if (count[num] <= 2)
                    result.Add(num);
            }

            return $"Массив после удаления: {string.Join(" ", result)}";
        }

        private string SolveTask12()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length < 2) throw new ArgumentException("Введите массив с как минимум двумя элементами");

            Dictionary<string, List<int>> positions = new Dictionary<string, List<int>>();
            for (int i = 0; i < numbers.Length; i++)
            {
                string num = numbers[i];
                if (!positions.ContainsKey(num))
                    positions[num] = new List<int>();
                positions[num].Add(i);
            }

            var duplicates = positions.Where(p => p.Value.Count == 2).ToList();
            if (duplicates.Count != 1)
                throw new ArgumentException("В массиве должно быть ровно два одинаковых элемента");

            var pair = duplicates.First();
            return $"Одинаковые элементы: {pair.Key} на позициях {pair.Value[0]} и {pair.Value[1]}";
        }

        private string SolveTask13()
        {
            string binary = ((TextBox)InputPanel.Children[1]).Text;
            if (!IsBinary(binary)) throw new ArgumentException("Введено не двоичное число");

            if (binary.Length < 3) throw new ArgumentException("Число должно содержать как минимум 3 цифры");

            // Циклический сдвиг влево на 2 позиции
            string shifted = binary.Substring(2) + binary.Substring(0, 2);

            // Разность исходного и полученного чисел
            int original = Convert.ToInt32(binary, 2);
            int shiftedValue = Convert.ToInt32(shifted, 2);
            int difference = original - shiftedValue;

            return $"Исходное число: {binary}\n" +
                   $"После сдвига: {shifted}\n" +
                   $"Разность: {difference} (десятичное)";
        }

        private string SolveTask14()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0) throw new ArgumentException("Введите массив двоичных чисел");

            foreach (string num in numbers)
            {
                if (!IsBinary(num)) throw new ArgumentException("Все числа должны быть двоичными");
            }

            // Сортировка по убыванию
            var sorted = numbers.OrderByDescending(n => Convert.ToInt32(n, 2)).ToArray();

            // Сумма чисел
            int sum = 0;
            foreach (string num in numbers)
            {
                sum += Convert.ToInt32(num, 2);
            }

            return $"Отсортированный массив: {string.Join(" ", sorted)}\n" +
                   $"Сумма чисел: {sum} (десятичное)";
        }

        private string SolveTask15()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0) throw new ArgumentException("Введите массив двоичных чисел");

            foreach (string num in numbers)
            {
                if (!IsBinary(num)) throw new ArgumentException("Все числа должны быть двоичными");
            }

            // Сортировка по возрастанию
            var sorted = numbers.OrderBy(n => Convert.ToInt32(n, 2)).ToArray();

            // Среднее значение
            double sum = 0;
            foreach (string num in numbers)
            {
                sum += Convert.ToInt32(num, 2);
            }
            double average = sum / numbers.Length;

            return $"Отсортированный массив: {string.Join(" ", sorted)}\n" +
                   $"Среднее значение: {average} (десятичное)";
        }

        private string SolveTask16()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0) throw new ArgumentException("Введите массив двоичных чисел");

            foreach (string num in numbers)
            {
                if (!IsBinary(num)) throw new ArgumentException("Все числа должны быть двоичными");
            }

            int minIndex = 0, maxIndex = 0;
            int minValue = Convert.ToInt32(numbers[0], 2);
            int maxValue = minValue;

            for (int i = 1; i < numbers.Length; i++)
            {
                int current = Convert.ToInt32(numbers[i], 2);
                if (current < minValue)
                {
                    minValue = current;
                    minIndex = i;
                }
                if (current > maxValue)
                {
                    maxValue = current;
                    maxIndex = i;
                }
            }

            // Меняем местами
            string temp = numbers[minIndex];
            numbers[minIndex] = numbers[maxIndex];
            numbers[maxIndex] = temp;

            return $"Массив после замены: {string.Join(" ", numbers)}\n" +
                   $"Минимальный элемент: {numbers[maxIndex]} (был на позиции {minIndex})\n" +
                   $"Максимальный элемент: {numbers[minIndex]} (был на позиции {maxIndex})";
        }

        private string SolveTask17()
        {
            string binary = ((TextBox)InputPanel.Children[1]).Text;
            if (!IsBinary(binary)) throw new ArgumentException("Введено не двоичное число");

            if (binary.Length < 2) throw new ArgumentException("Число должно содержать как минимум 2 цифры");

            // Циклический сдвиг вправо на 1 позицию
            string shifted = binary[binary.Length - 1] + binary.Substring(0, binary.Length - 1);

            // Сумма исходного и полученного чисел
            int original = Convert.ToInt32(binary, 2);
            int shiftedValue = Convert.ToInt32(shifted, 2);
            int sum = original + shiftedValue;

            return $"Исходное число: {binary}\n" +
                   $"После сдвига: {shifted}\n" +
                   $"Сумма: {sum} (десятичное)";
        }

        private string SolveTask18()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0) throw new ArgumentException("Введите целочисленный массив");

            List<int> array = new List<int>();
            foreach (string num in numbers)
            {
                if (!int.TryParse(num, out int n))
                    throw new ArgumentException("Все элементы должны быть целыми числами");
                array.Add(n);
            }

            if (array.Count < 2) return "Разность: 0 (массив слишком короткий для анализа)";

            double sumIncreasing = 0;
            double sumDecreasing = 0;
            List<int> currentSequence = new List<int> { array[0] };

            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] > array[i - 1])
                {
                    // Продолжение возрастающей последовательности
                    if (currentSequence.Count >= 2 && currentSequence.Last() > currentSequence[currentSequence.Count - 2])
                    {
                        currentSequence.Add(array[i]);
                    }
                    else
                    {
                        // Начало новой возрастающей последовательности
                        if (currentSequence.Count >= 3 && currentSequence.Last() < currentSequence[currentSequence.Count - 2])
                        {
                            // Завершение убывающей последовательности
                            sumDecreasing += currentSequence.Sum();
                        }
                        currentSequence = new List<int> { array[i - 1], array[i] };
                    }
                }
                else if (array[i] < array[i - 1])
                {
                    // Продолжение убывающей последовательности
                    if (currentSequence.Count >= 2 && currentSequence.Last() < currentSequence[currentSequence.Count - 2])
                    {
                        currentSequence.Add(array[i]);
                    }
                    else
                    {
                        // Начало новой убывающей последовательности
                        if (currentSequence.Count >= 3 && currentSequence.Last() > currentSequence[currentSequence.Count - 2])
                        {
                            // Завершение возрастающей последовательности
                            sumIncreasing += currentSequence.Sum();
                        }
                        currentSequence = new List<int> { array[i - 1], array[i] };
                    }
                }
                else
                {
                    // Последовательность прерывается
                    if (currentSequence.Count >= 3)
                    {
                        if (currentSequence.Last() > currentSequence[currentSequence.Count - 2])
                            sumIncreasing += currentSequence.Sum();
                        else if (currentSequence.Last() < currentSequence[currentSequence.Count - 2])
                            sumDecreasing += currentSequence.Sum();
                    }
                    currentSequence = new List<int> { array[i] };
                }
            }

            // Обработка последней последовательности
            if (currentSequence.Count >= 3)
            {
                if (currentSequence.Last() > currentSequence[currentSequence.Count - 2])
                    sumIncreasing += currentSequence.Sum();
                else if (currentSequence.Last() < currentSequence[currentSequence.Count - 2])
                    sumDecreasing += currentSequence.Sum();
            }

            double difference = sumIncreasing - sumDecreasing;
            return $"Сумма возрастающих участков: {sumIncreasing}\n" +
                   $"Сумма убывающих участков: {sumDecreasing}\n" +
                   $"Разность: {difference}";
        }

        private string SolveTask19()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length < 2) throw new ArgumentException("Введите как минимум 2 числа");

            List<int> array = new List<int>();
            foreach (string num in numbers)
            {
                if (!int.TryParse(num, out int n))
                    throw new ArgumentException("Все элементы должны быть целыми числами");
                array.Add(n);
            }

            if (array.Count < 2) return "не образуют (массив слишком короткий)";

            int difference = array[1] - array[0];
            for (int i = 2; i < array.Count; i++)
            {
                if (array[i] - array[i - 1] != difference)
                    return "не образуют";
            }

            return $"образуют, разность прогрессии: {difference}";
        }

        private string SolveTask20()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length < 2) throw new ArgumentException("Введите как минимум 2 числа");

            List<double> array = new List<double>();
            foreach (string num in numbers)
            {
                if (!double.TryParse(num, out double n))
                    throw new ArgumentException("Все элементы должны быть числами");
                array.Add(n);
            }

            if (array.Count < 2) return "не образуют (массив слишком короткий)";
            if (array[0] == 0) return "не образуют (первый элемент равен 0)";

            double ratio = array[1] / array[0];
            for (int i = 2; i < array.Count; i++)
            {
                if (Math.Abs(array[i] / array[i - 1] - ratio) > 0.000001)
                    return "не образуют";
            }

            return $"образуют, знаменатель прогрессии: {ratio}";
        }

        private string SolveTask21()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0) throw new ArgumentException("Введите целочисленный массив");

            List<int> array = new List<int>();
            foreach (string num in numbers)
            {
                if (!int.TryParse(num, out int n))
                    throw new ArgumentException("Все элементы должны быть целыми числами");
                array.Add(n);
            }

            List<int> indices = new List<int>();
            for (int i = 0; i < array.Count - 1; i++)
            {
                bool allSmaller = true;
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (array[i] <= array[j])
                    {
                        allSmaller = false;
                        break;
                    }
                }
                if (allSmaller)
                    indices.Add(i);
            }

            // Последний элемент всегда удовлетворяет условию
            indices.Add(array.Count - 1);

            return $"Индексы элементов: {string.Join(" ", indices)}\n" +
                   $"Количество таких чисел: {indices.Count}";
        }

        private string SolveTask22()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length < 3) return "таких нет (массив слишком короткий)";

            List<int> array = new List<int>();
            foreach (string num in numbers)
            {
                if (!int.TryParse(num, out int n))
                    throw new ArgumentException("Все элементы должны быть целыми числами");
                array.Add(n);
            }

            int lastIndex = -1;
            for (int i = 1; i < array.Count - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] < array[i + 1])
                {
                    lastIndex = i;
                }
            }

            if (lastIndex == -1)
                return "таких нет";
            else
                return $"Индекс последнего такого элемента: {lastIndex}";
        }

        private string SolveTask23()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0) throw new ArgumentException("Введите массив двоичных чисел");

            foreach (string num in numbers)
            {
                if (!IsBinary(num)) throw new ArgumentException("Все числа должны быть двоичными");
            }

            if (numbers.Length < 2) return "Невозможно определить (массив слишком короткий)";

            // Находим индексы минимального и максимального элементов
            int minIndex = 0, maxIndex = 0;
            int minValue = Convert.ToInt32(numbers[0], 2);
            int maxValue = minValue;

            for (int i = 1; i < numbers.Length; i++)
            {
                int current = Convert.ToInt32(numbers[i], 2);
                if (current < minValue)
                {
                    minValue = current;
                    minIndex = i;
                }
                if (current > maxValue)
                {
                    maxValue = current;
                    maxIndex = i;
                }
            }

            // Определяем количество элементов между ними
            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);
            int countBetween = end - start - 1;

            if (countBetween <= 0)
                return $"Между минимальным ({numbers[minIndex]}) и максимальным ({numbers[maxIndex]}) элементами нет чисел";
            else
                return $"Количество чисел между минимальным ({numbers[minIndex]}) и максимальным ({numbers[maxIndex]}): {countBetween}";
        }

        private string SolveTask24()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0) throw new ArgumentException("Введите массив двоичных чисел");

            foreach (string num in numbers)
            {
                if (!IsBinary(num)) throw new ArgumentException("Все числа должны быть двоичными");
            }

            if (numbers.Length < 2) return "Массив слишком короткий для сдвига";

            // Циклический сдвиг вправо на одну позицию
            string last = numbers[numbers.Length - 1];
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
            }
            numbers[0] = last;

            return $"Массив после сдвига: {string.Join(" ", numbers)}";
        }

        private string SolveTask25()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0) throw new ArgumentException("Введите массив двоичных чисел");

            foreach (string num in numbers)
            {
                if (!IsBinary(num)) throw new ArgumentException("Все числа должны быть двоичными");
            }

            // Вычисляем сумму до сдвига
            int sumBefore = 0;
            foreach (string num in numbers)
            {
                sumBefore += Convert.ToInt32(num, 2);
            }

            if (numbers.Length < 2) return $"Сумма до сдвига: {sumBefore}\nМассив слишком короткий для сдвига";

            // Циклический сдвиг влево на одну позицию
            string first = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = first;

            // Вычисляем сумму после сдвига
            int sumAfter = 0;
            foreach (string num in numbers)
            {
                sumAfter += Convert.ToInt32(num, 2);
            }

            return $"Сумма до сдвига: {sumBefore}\n" +
                   $"Массив после сдвига: {string.Join(" ", numbers)}\n" +
                   $"Сумма после сдвига: {sumAfter}";
        }

        private string SolveTask26()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0) throw new ArgumentException("Введите массив двоичных чисел");

            foreach (string num in numbers)
            {
                if (!IsBinary(num)) throw new ArgumentException("Все числа должны быть двоичными");
            }

            int increment = Convert.ToInt32("1010", 2); // 10 в десятичной
            List<string> result = new List<string>();

            foreach (string num in numbers)
            {
                int value = Convert.ToInt32(num, 2);
                value += increment;
                result.Add(Convert.ToString(value, 2));
            }

            return $"Массив после увеличения: {string.Join(" ", result)}";
        }

        private string SolveTask27()
        {
            string arrayInput = ((TextBox)InputPanel.Children[1]).Text;
            string numberInput = ((TextBox)InputPanel.Children[3]).Text;

            string[] numbers = arrayInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0) throw new ArgumentException("Введите массив вещественных чисел");

            if (!double.TryParse(numberInput, out double R))
                throw new ArgumentException("Введите корректное число R");

            List<double> array = new List<double>();
            foreach (string num in numbers)
            {
                if (!double.TryParse(num, out double n))
                    throw new ArgumentException("Все элементы массива должны быть числами");
                array.Add(n);
            }

            int closestIndex = 0;
            double closestValue = array[0];
            double minDifference = Math.Abs(array[0] - R);

            for (int i = 1; i < array.Count; i++)
            {
                double difference = Math.Abs(array[i] - R);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    closestIndex = i;
                    closestValue = array[i];
                }
            }

            return $"Ближайший элемент: {closestValue} (индекс {closestIndex})";
        }

        private string SolveTask28()
        {
            string arrayInput = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = arrayInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0) throw new ArgumentException("Введите массив двоичных чисел");

            foreach (string num in numbers)
            {
                if (!IsBinary(num)) throw new ArgumentException("Все числа должны быть двоичными");
            }

            // Просим пользователя ввести D (в реальном приложении нужно добавить поле ввода)
            // Для примера возьмем D = "1010"
            string D = "1010";
            int dValue = Convert.ToInt32(D, 2);

            int farthestIndex = 0;
            string farthestValue = numbers[0];
            int maxDifference = Math.Abs(Convert.ToInt32(numbers[0], 2) - dValue);

            for (int i = 1; i < numbers.Length; i++)
            {
                int currentDifference = Math.Abs(Convert.ToInt32(numbers[i], 2) - dValue);
                if (currentDifference > maxDifference)
                {
                    maxDifference = currentDifference;
                    farthestIndex = i;
                    farthestValue = numbers[i];
                }
            }

            return $"Наиболее удаленный элемент: {farthestValue} (индекс {farthestIndex})\n" +
                   $"Разница с числом {D}: {maxDifference} (десятичное)";
        }

        private string SolveTask29()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 2) throw new ArgumentException("Введите два двоичных числа (положительное и отрицательное)");

            foreach (string num in numbers)
            {
                if (!IsBinary(num)) throw new ArgumentException("Все числа должны быть двоичными");
            }

            // Определяем, какое число отрицательное (по знаку первого бита)
            int positive, negative;
            if (numbers[0].StartsWith("1"))
            {
                negative = Convert.ToInt32(numbers[0], 2);
                positive = Convert.ToInt32(numbers[1], 2);
            }
            else
            {
                positive = Convert.ToInt32(numbers[0], 2);
                negative = Convert.ToInt32(numbers[1], 2);
            }

            int sum = positive + negative;
            string binarySum = Convert.ToString(sum, 2);

            return $"Сумма: {binarySum} (двоичное)\n" +
                   $"Десятичное представление: {positive} + ({negative}) = {sum}";
        }

        private string SolveTask30()
        {
            string input = ((TextBox)InputPanel.Children[1]).Text;
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 3) throw new ArgumentException("Введите ровно 3 десятичных числа");

            List<int> array = new List<int>();
            foreach (string num in numbers)
            {
                if (!int.TryParse(num, out int n))
                    throw new ArgumentException("Все элементы должны быть целыми числами");
                array.Add(n);
            }

            List<string> binaryArray = new List<string>();
            foreach (int num in array)
            {
                binaryArray.Add(Convert.ToString(num, 2));
            }

            return $"Двоичный массив: {string.Join(" ", binaryArray)}";
        }

        // Вспомогательные методы
        private bool IsBinary(string s)
        {
            foreach (char c in s)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }

        private bool IsFractionalBinary(string s)
        {
            bool hasDot = false;
            foreach (char c in s)
            {
                if (c == '.')
                {
                    if (hasDot) return false;
                    hasDot = true;
                }
                else if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsOctal(string s)
        {
            foreach (char c in s)
            {
                if (c < '0' || c > '7')
                    return false;
            }
            return true;
        }
    }
}