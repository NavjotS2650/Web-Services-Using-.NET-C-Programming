#include <stdio.h>

int main(void)
{
  float radius,diameter=0.0,area=0.0,circumference=0.0;

  printf("Enter the radius\n");
  scanf("%f",&radius);
  diameter= 2*radius;
  area= radius*radius*3.14157;
  circumference= 2*3.14*radius;

  printf("diameter of circle = %f\n",diameter);
  printf("area of circle = %f\n",area);
  printf("circumference of circle = %f\n",circumference);
}
