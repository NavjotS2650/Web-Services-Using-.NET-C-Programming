/*
  Student Grade Application Prog12974 Winter 2017 class:

  Description: write a program that reads a series of numbers that represent 
  student marks for the PROG12974 course. Your program should inform the 
  user of the corresponding student grade for each mark. Ensure that only 
  valid marks are processed. Additionally, compute the average mark for all 
  the sudents and determine the overall average grade for the class (if
  students were processed). Use the following test data to test your 
  program:

  test values 84, 67, 364, 91, -45, 55, 43, 77, 61, 70
*/

int main(void)
{
unsigned int count=0;
float mark, totalMark=0.0, average=0.0;

printf("Enter a student marks... -1 to quit:");
scanf("%f",&mark);
while(mark !=-1){
if(mark<0 || mark>100){
printf("Please Enter a valid Marks!!! :(");
}
else if(mark > 80){
printf("You got A Grade. :)");
totalMark +=mark;
count++;
}
else if(mark > 70){
printf("You got B Grade. :)");
totalMark +=mark;
count++;
}
else if(mark > 60){
printf("You got C Grade. :)");
totalMark +=mark;
count++;
}
else if(mark >= 50){
printf("You got D Grade. :)");
totalMark +=mark;
count++;
}
else{
printf("You got F Grade. :(");
totalMark +=mark;
count++;
}
printf("Enter a Student Mark... -1 to quit: ");
scanf("%f",&mark);
}
if(count == 0){
printf("No Student data Processed");
}
else
average=totalMark/count;
if(average > 80){
printf("Overall Average is A :)");
}
else if(average >70)
{
printf("Overall Average is B.");
}
else if(average >60)
{
printf("Overall Average is C.");
}
else if(average >50)
{
printf("Overall Average is D.");
}
else{
printf("Overall Average is F.");
}
}




