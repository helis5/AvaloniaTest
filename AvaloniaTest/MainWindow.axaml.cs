using Avalonia.Controls;

namespace AvaloniaTest;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();


    }

    private void CheckResults_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {

        bool allAnswered = true;

        // Вопрос 1 (RadioButton)
        if (rbQ1_1.IsChecked == false && rbQ1_2.IsChecked == false &&
            rbQ1_3.IsChecked == false && rbQ1_4.IsChecked == false)
            allAnswered = false;

        // Вопрос 2 (CheckBox)
        if (chQ2_1.IsChecked == false && chQ2_2.IsChecked == false &&
            chQ2_3.IsChecked == false && chQ2_4.IsChecked == false)
            allAnswered = false;

        // Вопрос 3 (RadioButton)
        if (rbQ3_1.IsChecked == false && rbQ3_2.IsChecked == false &&
            rbQ3_3.IsChecked == false && rbQ3_4.IsChecked == false)
            allAnswered = false;

        // Вопрос 4 (CheckBox)
        if (chQ4_1.IsChecked == false && chQ4_2.IsChecked == false &&
            chQ4_3.IsChecked == false && chQ4_4.IsChecked == false &&
            chQ4_5.IsChecked == false && chQ4_6.IsChecked == false)
            allAnswered = false;

        // Вопрос 5 (RadioButton)
        if (rbQ5_1.IsChecked == false && rbQ5_2.IsChecked == false &&
            rbQ5_3.IsChecked == false && rbQ5_4.IsChecked == false)
            allAnswered = false;

        // Вопрос 6 (CheckBox)
        if (chQ6_1.IsChecked == false && chQ6_2.IsChecked == false &&
            chQ6_3.IsChecked == false && chQ6_4.IsChecked == false)
            allAnswered = false;

        // Вопрос 7 (RadioButton)
        if (rbQ7_1.IsChecked == false && rbQ7_2.IsChecked == false &&
            rbQ7_3.IsChecked == false && rbQ7_4.IsChecked == false)
            allAnswered = false;

        if (!allAnswered)
        {
            Status.Foreground = Avalonia.Media.Brushes.Red;
            Status.Text = $"Пожалуйста, ответьте на все вопросы";
            return;
        }



        int correctAnswers = 0;
        // Вопрос 1
        if (rbQ1_1.IsChecked == true && rbQ1_2.IsChecked == false && rbQ1_3.IsChecked == false && rbQ1_4.IsChecked == false)
            correctAnswers++;

        // Вопрос 2
        if (chQ2_1.IsChecked == true && chQ2_2.IsChecked == true && chQ2_3.IsChecked == false && chQ2_4.IsChecked == false)
            correctAnswers++;

        // Вопрос 3
        if (rbQ3_1.IsChecked == true && rbQ3_2.IsChecked == false && rbQ3_3.IsChecked == false && rbQ3_4.IsChecked == false)
            correctAnswers++;

        // Вопрос 4
        if (chQ4_1.IsChecked == true && chQ4_2.IsChecked == true && chQ4_3.IsChecked == true &&
            chQ4_4.IsChecked == false && chQ4_5.IsChecked == true && chQ4_6.IsChecked == true)
            correctAnswers++;

        // Вопрос 5
        if (rbQ5_1.IsChecked == true && rbQ5_2.IsChecked == false && rbQ5_3.IsChecked == false && rbQ5_4.IsChecked == false)
            correctAnswers++;

        // Вопрос 6
        if (chQ6_1.IsChecked == true && chQ6_2.IsChecked == true && chQ6_3.IsChecked == true && chQ6_4.IsChecked == false)
            correctAnswers++;

        // Вопрос 7
        if (rbQ7_1.IsChecked == true && rbQ7_2.IsChecked == false && rbQ7_3.IsChecked == false && rbQ7_4.IsChecked == false)
            correctAnswers++;

        // Вывод результата
        Status.Foreground = Avalonia.Media.Brushes.Green;
        if (correctAnswers < 2)
        {
            Status.Foreground = Avalonia.Media.Brushes.Red;
        }
        else if (correctAnswers < 5)
        {
            Status.Foreground = Avalonia.Media.Brushes.Orange;
        }
        else if (correctAnswers <= 7)
        {
            Status.Foreground = Avalonia.Media.Brushes.Green;
        }

        Status.Text = $"Правильных ответов: {correctAnswers} из 7";


    }
}