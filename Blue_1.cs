using System;

namespace Lab_8
{
    public class Blue_1 : Blue
    {
        //Поля и свойства
        private string[] _output;
        public string[] Output => _output;

        //Конструктор
        public Blue_1(string input) : base(input)
        {
            _output = null;
        }

        public override void Review()
        {
            if (string.IsNullOrEmpty(Input))
            {
                _output = null;
                return;
            }

            string[] ans = new string[0];
            _output = Input.Split(' ');
            for (int i = 0; i < _output.Length;)
            {
                string curr = "";
                int cnt = _output[i].Length; //Счетчик длины текущей строки
                while (cnt <= 50)
                {
                    curr += _output[i++] + " ";
                    //Проверяем, есть ли следующее слово
                    if (i != _output.Length)
                    {
                        cnt += _output[i].Length + 1;
                    } else {
                        break;
                    }
                }
                string[] newStrings = new string[ans.Length + 1]; //Добавляем сформированную строку в массив результатов
                Array.Copy(ans, newStrings, ans.Length);
                ans = newStrings;
            }
            _output = ans;
        }

        public override string ToString()
        {
            if (_output == null || _output.Length == 0)
            {
                return string.Empty;
            }
            return string.Join(Environment.NewLine, _output);  //Объединяем строки результата через перевод строки

        }
    }
}