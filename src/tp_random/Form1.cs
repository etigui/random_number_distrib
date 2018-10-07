using System;
using System.Windows.Forms;

/*
 * My random (pseudrandom number generator)
 * x[n+1] = (p1 * x[n] + p2) mod n
 * Sources: https://books.google.ch/books?id=L2JYZYI_l_wC&pg=PT575&lpg=PT575&dq=random+p1,+p2,+x0&source=bl&ots=9v0nKD8-E3&sig=YWarFLfmpBBXIXQASxOZvmzYv6w&hl=de&sa=X&ved=0ahUKEwjc5aem65bQAhULlxoKHU_cAfgQ6AEIKjAA#v=onepage&q=random%20p1%2C%20p2%2C%20x0&f=false
 * 
 * Pareto and exponetial distribution
 * Sources: http://www.pamvotis.org/vassis/RandGen.htm
 */

namespace tp_random
{
    public partial class Form1 : Form
    {
        const double MAX_DRAW = 10000;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e) {
            display_result();
        }

        private void display_result() {

            // Windows rand init
            double rand = 0;
            double sum = 0;
            double sum_squared = 0;
            Random random = new Random();

            // My rand init
            double my_rand = 0;
            double my_sum = 0;
            double my_sum_squared = 0;
            double seed = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            const double p1 = 16807, p2 = 0, n = uint.MaxValue;

            // Array init
            int[] uniform_array = new int[10];
            int[] my_rand_array = new int[10];
            int[] expo_array = new int[10];
            int[] pareto_array = new int[10];

            for (int i = 0; i < MAX_DRAW; i++) {

                // Windows random generation
                rand = uniform_distrib(random);
                sum += rand;
                sum_squared += Math.Pow(rand, 2);

                //My random generation 
                my_rand = my_random(seed, n, p1, p2);
                seed = my_rand;
                my_rand = my_rand / n;
                my_sum += my_rand;
                my_sum_squared += Math.Pow(my_rand, 2);

                //Fill in array
                uniform_array = fill_in_array(uniform_array, rand);
                my_rand_array = fill_in_array(my_rand_array, my_rand);
                expo_array = fill_in_array(expo_array, expo_distrib(my_rand));
                pareto_array = fill_in_array(pareto_array, pareto_distrib(my_rand));
            }

            // Display result
            Result res_uniform_distrib = new Result();
            res_uniform_distrib.Rand_type = "Uniform distribution";
            res_uniform_distrib.Average = average(sum).ToString();
            res_uniform_distrib.Standard_deviation = standard_deviation(sum, sum_squared).ToString();
            res_uniform_distrib.Variance = variance(sum, sum_squared).ToString();
            res_uniform_distrib.Values = uniform_array;
            res_uniform_distrib.Max_draw = get_max_draw(uniform_array);
            res_uniform_distrib.Show();

            Result res_my_rand = new Result();
            res_my_rand.Rand_type = "My random";
            res_my_rand.Average = average(my_sum).ToString();
            res_my_rand.Standard_deviation = standard_deviation(my_sum, my_sum_squared).ToString();
            res_my_rand.Variance = variance(my_sum, my_sum_squared).ToString();
            res_my_rand.Values = my_rand_array;
            res_my_rand.Max_draw = get_max_draw(my_rand_array);
            res_my_rand.Show();

            Result res_expo_distrib = new Result();
            res_expo_distrib.Rand_type = "Exponential distribution";
            res_expo_distrib.Values = expo_array;
            res_expo_distrib.Max_draw = get_max_draw(expo_array);
            res_expo_distrib.Show();

            Result res_pareto_distrib = new Result();
            res_pareto_distrib.Rand_type = "Pareto distribution";
            res_pareto_distrib.Values = pareto_array;
            res_pareto_distrib.Max_draw = get_max_draw(pareto_array);
            res_pareto_distrib.Show();
        }

        private double my_random(double seed, double n, double p1, double p2) {
            return (p1 * seed + p2) % n;
        }

        private double uniform_distrib(Random rand) {
            return rand.NextDouble();
        }

        private double expo_distrib(double rand) {
            return -Math.Log((1 - rand + Math.Pow(10, -12)));
        }

        private double pareto_distrib(double rand) {
            return (1 / (Math.Sqrt(1 - rand + Math.Pow(10, -12)))) - 1;
        }

        private double average(double sum) {
            return sum / MAX_DRAW;
        }

        private double variance(double sum, double sum_squared) {
            return (sum_squared / MAX_DRAW) - Math.Pow(average(sum), 2);
        }

        private double standard_deviation(double sum, double sum_squared) {
            return Math.Sqrt(variance(sum_squared, sum));
        }

        private int[] fill_in_array(int[] array, double value) {
            if (value > 0 && value < 0.1) {
                array[0]++;
            } else if (value > 0.1 && value < 0.2) {
                array[1]++;
            } else if (value > 0.2 && value < 0.3) {
                array[2]++;
            } else if (value > 0.3 && value < 0.4) {
                array[3]++;
            } else if (value > 0.4 && value < 0.5) {
                array[4]++;
            } else if (value > 0.5 && value < 0.6) {
                array[5]++;
            } else if (value > 0.6 && value < 0.7) {
                array[6]++;
            } else if (value > 0.7 && value < 0.8) {
                array[7]++;
            } else if (value > 0.8 && value < 0.9) {
                array[8]++;
            } else if (value > 0.9 && value <= 1) {
                array[9]++;
            }
            return array;
        }

        private string get_max_draw(int[] array) {
            int total = 0;
            for (int i = 0; i < 10; i++) {
                total += array[i];
            }
            return $"{total.ToString()}/{MAX_DRAW}";
        }
    }
}