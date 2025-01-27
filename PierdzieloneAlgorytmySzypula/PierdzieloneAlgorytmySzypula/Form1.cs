using System.Security.Cryptography.Pkcs;

namespace PierdzieloneAlgorytmySzypula
{
    public partial class Form1 : Form
    {
        private int[] array;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void OnGenerateArrayButtonClick(object sender, EventArgs e)
        {
            this.array = Sorter.GenerateRandomArray(10, -100, 100);
            this.inputLabel.Text = this.ConvertArrayToString(this.array);
        }

        private string ConvertArrayToString(int[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += $"{array[i]} ";
            }

            return result;
        }
        private void RefreshResult()
        {
            this.resultLabel.Text = this.ConvertArrayToString(this.array);
        }

        private void OnBubbleSortButtonClick(object sender, EventArgs e)
        {
            this.array = TestSort.BubbleSort(this.array);
            this.RefreshResult();

        }

        private void OnInsertionSortButtonClick(object sender, EventArgs e)
        {
            this.array = TestSort.InsertionSort(this.array);
            this.RefreshResult();
        }

        private void OnCountingButtonClick(object sender, EventArgs e)
        {
            this.array = Sorter.CountingSort(this.array);
            this.RefreshResult();
        }

        private void OnMergeButtonClick(object sender, EventArgs e)
        {
            this.array = TestSort.MergeSort(this.array);
            this.RefreshResult();
        }

        private void OnQuickButtonClick(object sender, EventArgs e)
        {
            this.array = TestSort.QuickSortHelper(this.array);
            this.RefreshResult();
        }
    }
}