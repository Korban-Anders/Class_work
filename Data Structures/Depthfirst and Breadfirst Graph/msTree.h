#include "graph.h"
class msTreeType: public graphType
{
public:
void createSpanningGraph();
//Function to create the graph and the weight matrix.
//Postcondition: The graph using adjacency lists and
// its weight matrix is created.
void minimumSpanning(int sVertex);
//Function to create a minimum spanning tree with
//root as sVertex.
// Postcondition: A minimum spanning tree is created.
// The weight of the edges is also saved in the array
// edgeWeights.
void printTreeAndWeight();
//Function to output the edges of the minimum spanning tree
//and the weight of the minimum spanning tree.
//Postcondition: The edges of a minimum spanning tree
// and their weights are printed.
msTreeType(int size = 0);
//Constructor
//Postcondition: gSize = 0; maxSize = size;
// graph is an array of pointers to linked lists.
// weights is a two-dimensional array to store the weights
// of the edges.
// edges is an array to store the edges of a minimum
// spanning tree.
// edgeWeights is an array to store the weights of the
// edges of a minimum spanning tree.
~msTreeType();
//Destructor
//The storage occupied by the vertices and the arrays
//weights, edges, and edgeWeights is deallocated.
protected:
int source;
double **weights;
int *edges;
double *edgeWeights;
}; 