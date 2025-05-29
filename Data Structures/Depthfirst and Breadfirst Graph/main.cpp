
/* Program name: M13 Programming Assignment
*  Author: Korban Anders
*  Date last updated: 4/27/2022
* Purpose: create a program that makes and dispalys a graph using breadth and depth first. Then have a traversal that determines if there is connectivty between two vertexes
*/


#include <iostream>
#include "graph.h"

using namespace std;

int main()
{
    graphType g(100);
    g.createGraph();
    g.printGraph();

    cout << endl;

    g.depthFirstTraversal();
    cout << endl;
    g.breadthFirstTraversal();
    cout << endl;

    g.connectivity();

    return 0;
}