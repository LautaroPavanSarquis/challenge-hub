#include <bits/stdc++.h>

using namespace std;

string ltrim(const string &);
string rtrim(const string &);
vector<string> split(const string &);

/*

  Challenge:

  Complete the 'plusMinus' function below.

  The function accepts INTEGER_ARRAY arr as parameter.


  Input Format:

  The first line contains an integer, , the size of the array.
  The second line contains  space-separated integers that describe .

      STDIN           Function
      -----           --------
        6             arr[] size n = 6
    -4 3 -9 0 4 1     arr = [-4, 3, -9, 0, 4, 1]
 */


void plusMinus(vector<int> arr) {

    float positivos = 0;
    float negativos = 0;
    float ceros = 0;

    int arrSize= arr.size();

    for(int i = 0; i < arrSize; i++ )
    {
        if(arr[i]>0)
        {
            positivos ++;
        }
        else if (arr[i]<0 ){
            negativos++;
        }
        else {
            ceros ++;
        }
    }
        positivos = positivos/arrSize;
        negativos = negativos/arrSize;
        ceros = ceros/arrSize;

        printf("%f  \n%f  \n%f",positivos ,negativos, ceros);
}


int main()
{
    string n_temp;
    getline(cin, n_temp);

    int n = stoi(ltrim(rtrim(n_temp)));

    string arr_temp_temp;
    getline(cin, arr_temp_temp);

    vector<string> arr_temp = split(rtrim(arr_temp_temp));

    vector<int> arr(n);

    for (int i = 0; i < n; i++) {
        int arr_item = stoi(arr_temp[i]);

        arr[i] = arr_item;
    }

    plusMinus(arr);

    return 0;
}

string ltrim(const string &str) {
    string s(str);

    s.erase(
        s.begin(),
        find_if(s.begin(), s.end(), not1(ptr_fun<int, int>(isspace)))
    );

    return s;
}


string rtrim(const string &str) {
    string s(str);

    s.erase(
        find_if(s.rbegin(), s.rend(), not1(ptr_fun<int, int>(isspace))).base(),
        s.end()
    );

    return s;
}

vector<string> split(const string &str) {
    vector<string> tokens;

    string::size_type start = 0;
    string::size_type end = 0;

    while ((end = str.find(" ", start)) != string::npos) {
        tokens.push_back(str.substr(start, end - start));

        start = end + 1;
    }

    tokens.push_back(str.substr(start));

    return tokens;
}
