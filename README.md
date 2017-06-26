# QBRatingCalculator
---
## Table of Contents

- Description
- How to Build
- How to Use
- How Passer Rating is Calculated

## Description
This is one of my very first programs I made, around September 10, 2008. It calculates a quarterback's passer rating in football. This was made to get a better grasp of Visual Studio and user interface design.

## How to Build

Download the repository and extract the contents to a folder. Then, use Visual Studio (2015 or later, this project was updated) to open the solution. There, you can build and run the program.

## How to Use

Use of this program is simple. Add the quarterback's name in the top bar. Then, add the quarterback's total completions, attempts, yards, touchdowns, and interceptions. Once that's done, click on the "Go!" button to get the QB rating.

## How Passer Rating is Calculated

This program primarily uses the NFL/CFL formula for calculating the passer rating. The formula is divided into four components based on the stats. These components are denoted a, b, c, and d respectively.

- ![](http://https://wikimedia.org/api/rest_v1/media/math/render/svg/d0cf9b3484a1bd6e8b21d985ca392fe003a65cfa)
- ![](http:/https://wikimedia.org/api/rest_v1/media/math/render/svg/3864e4934d831230be43ceb64ad940776f314024/)
- ![](https://wikimedia.org/api/rest_v1/media/math/render/svg/8783a051cb0c490058e607291976288210839be2)
- ![](https://wikimedia.org/api/rest_v1/media/math/render/svg/53b626cff6ce1beba0c6bf3c02aca666a9f3a697)

Once the four components have been calculated, then they are summed up, divided by 6, and multiplied by 100.

![](https://wikimedia.org/api/rest_v1/media/math/render/svg/3b3a6857c3faa89cf62df17a858882ec0360f5ec)

