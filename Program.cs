int[] firstArray={0,1,2,3,4,5,6,7,8,9};
String[] secondArray={"Tim","Martin","Niki","Sara"};
bool[] thirdArray={true,false,true,false,true,false,true,false,true,false};


List <string> flavors=new List<string>();
flavors.Add("Vanilla");
flavors.Add("Chocolate");
flavors.Add("Blue Moon");
flavors.Add("Strawberry");
flavors.Add("Coffee");
Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.RemoveAt(2);
Console.WriteLine(flavors.Count);


Dictionary<string,string> dict=new Dictionary<string, string>();
Random rand=new Random();
for (int i=0;i<secondArray.Length;i++){
    dict.Add(secondArray[i],flavors[rand.Next(flavors.Count)]);
}
foreach(var person in dict){
    Console.WriteLine(person.Key+"-"+person.Value);
}

