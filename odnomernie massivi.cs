{
    try
    {
        string[] b = richTextBox1.Lines;
        int n = b.Length;
        int[] a = new int[n];
        int i, min, max, imin, imax;
        for (i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(b[i]);
        }
        min = max = a[0];
        imin = imax = 0;
        for (i = 0; i < n; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
                imin = i;
            }
            if (a[i] > max)
            {
                max = a[i];
                imax = i;
            }
            //a[imax] = min; - таким способом пробовал менять местами элементы
            //a[imin] = max; - таким способом пробовал менять местами элементы
            // где то тут надо вывод массива сделать, через текст бох рич текст бокс без разницы.
        }
        textBox1.Text = ("max=" + Convert.ToString(max) + "; min=" + Convert.ToString(min));
    }
    catch { textBox1.Text = Convert.ToString("Неверный формат"); }
}
private void button2_Click(object sender, EventArgs e)
{
    //textBox1.Text = Convert.ToString("");
    richTextBox1.Text = Convert.ToString("");
    textBox1.Clear();
}
private void Form1_Load(object sender, EventArgs e)
{
}
