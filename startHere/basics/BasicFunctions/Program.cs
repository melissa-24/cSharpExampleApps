static int add(int a, int b) {
    int c = a + b;
    return c;
}

Console.WriteLine(add(2,3));

static bool check(string word, string otherWord) {
    bool result = true;
    if(word != otherWord) {
        result = false;
    }
    return result;
}
Console.WriteLine(check("taco", "cat"));
Console.WriteLine(check("taco", "taco"));

string[] array01 = {"taco", "cat", "taco", "cat"};

static string[] newCheck(string[] arr, string word) {
    string[] result = new string[arr.Length];
    for(int i =0; i < arr.Length; i++) {
        if(word == arr[i]) {
            arr[i] = "Same";
            // Console.WriteLine(arr[i]);
        }
        Console.WriteLine(arr[i]);
    }
    return arr;
}
newCheck(array01, "taco");