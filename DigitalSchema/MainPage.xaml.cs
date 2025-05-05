using DigitalSchema.Chips;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DigitalSchema.Models;
using Microsoft.Maui.Controls.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Timers;

namespace DigitalSchema
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {

        // Таймер для обновления
        private System.Timers.Timer _timer;

        public Dictionary<Ellipse, List<Ellipse>> Commutation = new Dictionary<Ellipse, List<Ellipse>>();
        public Dictionary<Ellipse, Label> bindingLabels = new Dictionary<Ellipse, Label>(); // Визуальная часть привязки
        

        public Ellipse? SelectedEllipse { get; set; }

        private int number;
        private bool _editing;
        public bool Editing
        {
            get => _editing;
            set
            {
                SelectedEllipse = null;
                _editing = value;
                foreach (var labelPair in bindingLabels)
                {
                    labelPair.Value.TextColor = Colors.GreenYellow;
                }
                OnPropertyChanged();
            }
        }
        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex != -1)
            {
                switch(picker.SelectedIndex)
                {
                    case 0:
                        {
                            decoder.IsVisible = true;
                            break;
                        }
                    default:
                        {
                            decoder.IsVisible = false;
                            break;
                        }
                }
            }
            else
            {
                decoder.IsVisible = false;
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            number = 0;
            StartUpdatingEllipses();

            UM11UI.EllipseTapped += OnEllipseTapped;
            UM11UI.ExitEllipseTapped += OnExitEllipseTapped;
            UM11UI.ColorChanged += OnEllipseColorChanged;

            ChipAndOrKE1.EllipseTapped += OnEllipseTapped;
            ChipAndOrKE1.ExitEllipseTapped += OnExitEllipseTapped;
            ChipAndOrKE1.ColorChanged += OnEllipseColorChanged;

            ChipOne.EllipseTapped += OnEllipseTapped;
            ChipOne.ExitEllipseTapped += OnExitEllipseTapped;
            ChipOne.ColorChanged += OnEllipseColorChanged;
            ChipTwo.EllipseTapped += OnEllipseTapped;
            ChipTwo.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTwo.ColorChanged += OnEllipseColorChanged;

            ChipOne2.EllipseTapped += OnEllipseTapped;
            ChipOne2.ExitEllipseTapped += OnExitEllipseTapped;
            ChipOne2.ColorChanged += OnEllipseColorChanged;
            ChipTwo2.EllipseTapped += OnEllipseTapped;
            ChipTwo2.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTwo2.ColorChanged += OnEllipseColorChanged;

            Chip3And1.EllipseTapped += OnEllipseTapped;
            Chip3And1.ExitEllipseTapped += OnExitEllipseTapped;
            Chip3And1.ColorChanged += OnEllipseColorChanged;
            Chip3And2.EllipseTapped += OnEllipseTapped;
            Chip3And2.ExitEllipseTapped += OnExitEllipseTapped;
            Chip3And2.ColorChanged += OnEllipseColorChanged;

            Chip3OrTwo2.EllipseTapped += OnEllipseTapped;
            Chip3OrTwo2.ExitEllipseTapped += OnExitEllipseTapped;
            Chip3OrTwo2.ColorChanged += OnEllipseColorChanged;

            ChipTT1.EllipseTapped += OnEllipseTapped;
            ChipTT1.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTT1.ColorChanged += OnEllipseColorChanged;
            ChipTT2.EllipseTapped += OnEllipseTapped;
            ChipTT2.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTT2.ColorChanged += OnEllipseColorChanged;
            ChipTT3.EllipseTapped += OnEllipseTapped;
            ChipTT3.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTT3.ColorChanged += OnEllipseColorChanged;
            ChipTT4.EllipseTapped += OnEllipseTapped;
            ChipTT4.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTT4.ColorChanged += OnEllipseColorChanged;

            Chip4AndTwo1.EllipseTapped += OnEllipseTapped;
            Chip4AndTwo1.ExitEllipseTapped += OnExitEllipseTapped;
            Chip4AndTwo1.ColorChanged += OnEllipseColorChanged;

            Chip2XOR1.EllipseTapped += OnEllipseTapped;
            Chip2XOR1.ExitEllipseTapped += OnExitEllipseTapped;
            Chip2XOR1.ColorChanged += OnEllipseColorChanged;

            Chip2AND1.EllipseTapped += OnEllipseTapped;
            Chip2AND1.ExitEllipseTapped += OnExitEllipseTapped;
            Chip2AND1.ColorChanged += OnEllipseColorChanged;

            ChipKE1.EllipseTapped += OnEllipseTapped;
            ChipKE1.ExitEllipseTapped += OnExitEllipseTapped;
            ChipKE1.ColorChanged += OnEllipseColorChanged;
            ChipKE2.EllipseTapped += OnEllipseTapped;
            ChipKE2.ExitEllipseTapped += OnExitEllipseTapped;
            ChipKE2.ColorChanged += OnEllipseColorChanged;

            ChipSTT3.EllipseTapped += OnEllipseTapped;
            ChipSTT3.ExitEllipseTapped += OnExitEllipseTapped;
            ChipSTT3.ColorChanged += OnEllipseColorChanged;
            ChipSTT1.EllipseTapped += OnEllipseTapped;
            ChipSTT1.ExitEllipseTapped += OnExitEllipseTapped;
            ChipSTT1.ColorChanged += OnEllipseColorChanged;
            ChipSTT2.EllipseTapped += OnEllipseTapped;
            ChipSTT2.ExitEllipseTapped += OnExitEllipseTapped;
            ChipSTT2.ColorChanged += OnEllipseColorChanged;
            ChipSTT4.EllipseTapped += OnEllipseTapped;
            ChipSTT4.ExitEllipseTapped += OnExitEllipseTapped;
            ChipSTT4.ColorChanged += OnEllipseColorChanged;

            decoder.EllipseTapped += OnEllipseTapped;
            decoder.ExitEllipseTapped += OnExitEllipseTapped;
            decoder.ColorChanged += OnEllipseColorChanged;
        }

        private void ClearAll(object sender, System.EventArgs e)
        {

            // Clear all connections
            Commutation.Clear();

            // Remove all binding labels from UI and dictionary
            foreach (var labelPair in bindingLabels)
            {
                if (labelPair.Key.Parent is Grid parentGrid)
                {
                    parentGrid.Children.Remove(labelPair.Value);
                }
            }
            bindingLabels.Clear();

            SelectedEllipse = null;
            number = 0;
            return;
        }
        public void StartUpdatingEllipses()
        {
            _timer = new System.Timers.Timer(1000); // 1 секунда
            _timer.Elapsed += UpdateEllipseColors;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        private void UpdateEllipseColors(object sender, ElapsedEventArgs e)
        {
            foreach (var pair in Commutation)
            {
                foreach (var connectedEllipse in pair.Value)
                {
                    connectedEllipse.Fill = pair.Key.Fill;
                }
            }
        }

        private void OnEllipseColorChanged(object sender, Color newColor)
        {
            // Обновляем цвет всех связанных эллипсов
            foreach (var pair in Commutation)
            {
                foreach (var connectedEllipse in pair.Value)
                {
                    connectedEllipse.Fill = pair.Key.Fill;
                }
            }
        }

        private void OnEllipseTapped(object sender, Ellipse ellipse)
        {
            if (Editing == true)
            {
                if (SelectedEllipse != null)
                {
                    // Проверяем, что эллипсы уже связаны
                    if (IsAlreadyConnected(SelectedEllipse, ellipse))
                    {
                        // Удаляем связь и метки
                        RemoveConnection(SelectedEllipse, ellipse);
                        ellipse.Fill = Colors.Red;
                        SelectedEllipse = null;
                        return;
                    }
                    bool isConnected = Commutation.ContainsKey(ellipse) ||
                                 Commutation.Any(pair => pair.Value.Contains(ellipse));

                    if (isConnected)
                    {
                        DisplayAlert("Ошибка", "Данный контакт уже занят!", "OK");
                        return;
                    }
                    // Устанавливаем цвет
                    ellipse.Fill = SelectedEllipse.Fill;

                    // Определяем номер соединения
                    int connectionNumber = number;

                    // Если у исходного эллипса уже есть соединения, берем их номер
                    if (Commutation.ContainsKey(SelectedEllipse) && Commutation[SelectedEllipse].Count > 0)
                    {
                        connectionNumber = GetExistingConnectionNumber(SelectedEllipse);
                    }
                    else
                    {
                        // Если это новое соединение, увеличиваем номер
                        number++;
                    }

                    // Добавляем связь в словарь
                    if (!Commutation.ContainsKey(SelectedEllipse))
                    {
                        Commutation[SelectedEllipse] = new List<Ellipse>();
                    }
                    Commutation[SelectedEllipse].Add(ellipse);

                    // Создаем метки
                    CreateConnectionLabels(SelectedEllipse, ellipse, connectionNumber);

                    SelectedEllipse = null;
                }
            }
            else
            {
                UpdateLabelColors(ellipse);
            }
        }

        private void RemoveConnection(Ellipse source, Ellipse target)
        {
            // Удаляем связь из словаря
            if (Commutation.ContainsKey(source) && Commutation[source].Contains(target))
            {
                Commutation[source].Remove(target);
                if (Commutation[source].Count == 0)
                {
                    Commutation.Remove(source);
                    //number--;
                    //target.Fill = Colors.Red;
                    }
            }

            // Проверяем обратные связи
            foreach (var pair in Commutation.ToList())
            {
                if (pair.Value.Contains(source) && pair.Key == target)
                {
                    pair.Value.Remove(source);
                    if (pair.Value.Count == 0)
                    {
                        Commutation.Remove(pair.Key);
                    }
                }
            }

            // Удаляем метки
            RemoveConnectionLabels(source, target);
        }

        private void RemoveConnectionLabels(Ellipse source, Ellipse target)
        {
            // Удаляем метку у целевого эллипса
            if (bindingLabels.TryGetValue(target, out Label targetLabel))
            {
                var targetGrid = target.Parent as Grid;
                targetGrid?.Children.Remove(targetLabel);
                bindingLabels.Remove(target);
            }

            // Удаляем метку у исходного эллипса, если у него больше нет связей
            if (!Commutation.ContainsKey(source) || Commutation[source].Count == 0)
            {
                if (bindingLabels.TryGetValue(source, out Label sourceLabel))
                {
                    var sourceGrid = source.Parent as Grid;
                    sourceGrid?.Children.Remove(sourceLabel);
                    bindingLabels.Remove(source);
                }
            }
        }

        // Остальные методы остаются без изменений
        private int GetExistingConnectionNumber(Ellipse source)
        {
            // Проверяем метку у исходного эллипса
            if (bindingLabels.TryGetValue(source, out Label label))
            {
                if (label.Text.StartsWith(">"))
                {
                    if (int.TryParse(label.Text.Substring(1), out int num))
                    {
                        return num;
                    }
                }
            }

            // Проверяем метки у связанных эллипсов
            if (Commutation.ContainsKey(source))
            {
                foreach (var connectedEllipse in Commutation[source])
                {
                    if (bindingLabels.TryGetValue(connectedEllipse, out Label connectedLabel))
                    {
                        if (connectedLabel.Text.StartsWith(">"))
                        {
                            if (int.TryParse(connectedLabel.Text.Substring(1), out int num))
                            {
                                return num;
                            }
                        }
                    }
                }
            }

            return number; // возвращаем текущий номер, если не нашли
        }

        private bool IsAlreadyConnected(Ellipse source, Ellipse target)
        {
            // Проверяем, есть ли уже связь между этими эллипсами
            if (Commutation.ContainsKey(source) && Commutation[source].Contains(target))
                return true;
            return false;
        }

        private void CreateConnectionLabels(Ellipse source, Ellipse target, int connectionNumber)
        {
            // Метка у целевого эллипса
            var grid = target.Parent as Grid;
            if (grid != null)
            {
                string labelText = source.WidthRequest >= 12 ? source.AutomationId : ">" + connectionNumber;
                Color labelColor = source.WidthRequest >= 12 ? Colors.Red : Colors.GreenYellow;

                var label = new Label
                {
                    Text = labelText,
                    TextColor = labelColor,
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 14,
                    VerticalOptions = target.VerticalOptions,
                    HorizontalOptions = target.HorizontalOptions
                };

                grid.Children.Add(label);
                label.Margin = new Thickness(target.Margin.Left - 26, target.Margin.Top - 8, target.Margin.Right, target.Margin.Bottom);
                bindingLabels[target] = label;
            }

            // Метка у исходного эллипса создается только если это первая связь
            if (!Commutation.ContainsKey(source) || Commutation[source].Count <= 1)
            {
                var Outgrid = source.Parent as Grid;
                if (Outgrid != null)
                {
                    string outLabelText = target.WidthRequest >= 13 ? target.AutomationId : ">" + connectionNumber;
                    if (source.HeightRequest == 13) { outLabelText = source.AutomationId; }

                    var Outlabel = new Label
                    {
                        Text = outLabelText,
                        TextColor = Colors.GreenYellow,
                        FontAttributes = FontAttributes.Bold,
                        FontSize = 14,
                        VerticalOptions = source.VerticalOptions,
                        HorizontalOptions = source.HorizontalOptions
                    };

                    Outgrid.Children.Add(Outlabel);
                    Outlabel.Margin = new Thickness(source.Margin.Left+20, source.Margin.Top - 8, source.Margin.Right - 26, source.Margin.Bottom);

                    if (source.WidthRequest == 13)
                    {
                        Grid.SetColumn(Outlabel, Grid.GetColumn(source));
                        Grid.SetRow(Outlabel, Grid.GetRow(source));
                        Outlabel.Margin = new Thickness(source.Margin.Left - 20, source.Margin.Top - 8, source.Margin.Right - 26, source.Margin.Bottom);
                    }

                    bindingLabels[source] = Outlabel;
                }
            }
        }

        private void UpdateLabelColors(Ellipse selectedEllipse)
        {
            // Сначала делаем все метки зелеными
            foreach (var labelPair in bindingLabels)
            {
                labelPair.Value.TextColor = Colors.GreenYellow;
            }

            // Затем делаем метки связанные с выбранным эллипсом красными
            if (Commutation.ContainsKey(selectedEllipse))
            {
                // Метки у связанных эллипсов
                foreach (var connectedEllipse in Commutation[selectedEllipse])
                {
                    if (bindingLabels.TryGetValue(connectedEllipse, out Label label))
                    {
                        label.TextColor = Colors.Red;
                    }
                }

                // Метка у самого эллипса
                if (bindingLabels.TryGetValue(selectedEllipse, out Label mainLabel))
                {
                    mainLabel.TextColor = Colors.Red;
                }
            }

            // Проверяем обратные связи (где этот эллипс является целевым)
            foreach (var pair in Commutation)
            {
                if (pair.Value.Contains(selectedEllipse))
                {
                    if (bindingLabels.TryGetValue(pair.Key, out Label sourceLabel))
                    {
                        sourceLabel.TextColor = Colors.Red;
                    }

                    if (bindingLabels.TryGetValue(selectedEllipse, out Label targetLabel))
                    {
                        targetLabel.TextColor = Colors.Red;
                    }
                }
            }
        }
        private void OnExitEllipseTapped(object sender, Ellipse ellipse)
        {
            if (Editing == true)
            {
                // Проверяем, есть ли этот эллипс в каких-либо связях
                bool isConnected = Commutation.ContainsKey(ellipse) ||
                                  Commutation.Any(pair => pair.Value.Contains(ellipse));

                if (isConnected)
                {
                    // Можно добавить обработку удаления связей, если нужно
                }

                if (SelectedEllipse == null)
                {
                    SelectedEllipse = ellipse;
                }
            }
            else
            {
                UpdateLabelColors(ellipse);
            }
        }
    }
}
