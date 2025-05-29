#ifndef BINARY_TREE
#define BINARY_TREE



template <class Type>
struct binaryNode
{
	Type* info;
	binaryNode<Type>* lLink;
	binaryNode<Type>* rLink;
	~binaryNode() { delete info; };
};

template <class Type>
class binarySearchTree
{
public:
	const binarySearchTree<Type>& operator= (const binarySearchTree<Type>&);
	bool isEmpty() const;
	void inorderTraversal() const;
	void preorderTraversal() const;
	void postorderTraversal() const;
	int treeHeight() const;
	int treeNodeCount() const;
	int treeLeavesCount() const;
	void destroyTree();
	bool search(const Type& searchItem, int (*compare) (Type item1, Type item2)) const;
	void insert(const Type& insertItem, int (*compare) (Type item1, Type item2));
	void deleteNode(const Type& deleteItem, int (*compare) (Type item1, Type item2));
	binarySearchTree(const binarySearchTree<Type>& otherTree);
	binarySearchTree();
	~binarySearchTree();
	template <class T> friend ostream& operator<<(ostream& out, const binarySearchTree<T>& tree);
private:
	binaryNode<Type>* root;
	void inorder(binaryNode<Type>* p) const;
	void preorder(binaryNode<Type>* p) const;
	void postorder(binaryNode<Type>* p) const;
	int height(binaryNode<Type>* p) const;
	int max(int x, int y) const;
	int nodeCount(binaryNode<Type>* p) const;
	int leavesCount(binaryNode<Type>* p) const;
	void copyTree(binaryNode<Type>*& copiedTreeRoot, binaryNode<Type>* otherTreeRoot);
	string printTree() const;
	void destroy(binaryNode<Type>*& p);
	bool search(const Type& searchItem, binaryNode<Type>* p, int (*compare) (Type item1, Type item2)) const;
	void deleteFromTree(binaryNode<Type>*& p);
};

template <class Type>
bool binarySearchTree<Type>::isEmpty() const
{
	return (root == nullptr);
}
template <class Type>
void binarySearchTree<Type>::inorderTraversal() const
{
	inorder(root);
}
template <class Type>
void binarySearchTree<Type>::inorder(binaryNode<Type>* p) const
{
	if (p != nullptr)
	{
		inorder(p->lLink);
		cout << *p->info << endl;
		inorder(p->rLink);
	}
}
template <class Type>
void binarySearchTree<Type>::preorderTraversal() const
{
	preorder(root);
}
template <class Type>
void binarySearchTree<Type>::preorder(binaryNode<Type>* p) const
{
	if (p != nullptr)
	{
		cout << *p->info << " ";
		preorder(p->lLink);
		preorder(p->rLink);
	}
}
template <class Type>
void binarySearchTree<Type>::postorderTraversal() const
{
	postorder(root);
}
template <class Type>
void binarySearchTree<Type>::postorder(binaryNode<Type>* p) const
{
	if (p != nullptr)
	{
		postrder(p->lLink);

		postorder(p->rLink);
		cout << *p->info << " ";
	}
}
template <class Type>
int binarySearchTree<Type>::height(binaryNode<Type>* p) const
{
	if (p == nullptr)
	{
		return 0;
	}
	else
		return 1 + max(height(p->lLink), height(p->rLink));
}
template <class Type>
int binarySearchTree<Type>::treeHeight() const
{
	return height(root);
}
template <class Type>
int binarySearchTree<Type>::max(int x, int y) const
{
	if (x >= y)
		return x;
	else
		return y;
}
template <class Type>
void binarySearchTree<Type>::copyTree(binaryNode<Type>*& copiedTreeRoot, binaryNode<Type>* otherTreeRoot)
{
	if (otherTreeRoot == nullptr)
		copiedTreeRoot = nullptr;
	else
	{
		copiedTreeRoot = new binaryNode<Type>;
		copiedTreeRoot->info = new Type(*otherTreeRoot->info);
		copyTree(copiedTreeRoot->lLink, otherTreeRoot->lLink);
		copyTree(copiedTreeRoot->rLink, otherTreeRoot->rLink);
	}
}

template <class Type>
void binarySearchTree<Type>::insert(const Type& insertItem, int (*compare) (Type item1, Type item2))
{
	binaryNode<Type>* current;
	binaryNode<Type>* trailCurrent = nullptr;
	binaryNode<Type>* newNode;

	newNode = new binaryNode<Type>;
	newNode->info = new Type(insertItem);
	newNode->lLink = nullptr;
	newNode->rLink = nullptr;

	if (root == nullptr)
		root = newNode;
	else
	{
		current = root;
		while (current != nullptr)
		{
			trailCurrent = current;
			if ((*compare)(*current->info, insertItem) == 0)
			{
				cout << "The item is already in the tree" << endl;
				return;
			}
			else if ((*compare)(*current->info, insertItem) > 0)
				current = current->lLink;
			else
				current = current->rLink;
		}
		if ((*compare)(*trailCurrent->info, insertItem) > 0)
			trailCurrent->lLink = newNode;
		else
			trailCurrent->rLink = newNode;
	}
}
template <class Type>
void binarySearchTree<Type>::destroy(binaryNode<Type>*& p)
{
	if (p != nullptr)
	{
		destroy(p->lLink);
		destroy(p->rLink);
		delete p;
		p = nullptr;
	}
}
template <class Type>
void binarySearchTree<Type>::destroyTree()
{
	destroy(root);
}
template <class Type>
binarySearchTree<Type>::binarySearchTree()
{
	root = nullptr;
}
template <class Type>
binarySearchTree<Type>::~binarySearchTree()
{
	destroy(root);
}
template <class Type>
binarySearchTree<Type>::binarySearchTree(const binarySearchTree<Type>& otherTree)
{
	if (otherTree.root == nullptr)
		root = nullptr;
	else
		copyTree(root, otherTree.root);
}
template <class Type>
const binarySearchTree<Type>& binarySearchTree<Type>::operator=(const binarySearchTree<Type>& otherTree)
{
	if (this != &otherTree)
	{
		if (root != nullptr)
			destroy(root);
		if (otherTree.root == nullptr)
			root = nullptr;
		else
			copyTree(root, otherTree.root);
	}

	return *this;

}

template <class Type>
bool binarySearchTree<Type>::search(const Type& searchItem, int (*compare) (Type item1, Type item2)) const
{
	return search(searchItem, root, compare);
}

template <class Type>
bool binarySearchTree<Type>::search(const Type& searchItem, binaryNode<Type>* p, int (*compare) (Type item1, Type item2)) const
{
	if (p == nullptr)
		return false;
	else
	{
		if ((*compare)(*p->info, searchItem) == 0)
			return true;
		else if ((*compare)(searchItem, *p->info) < 0)
			return search(searchItem, p->lLink, compare);
		else
			return search(searchItem, p->rLink, compare);

	}
}

template <class Type>
void binarySearchTree<Type>::deleteFromTree(binaryNode<Type>*& p)
{
	binaryNode<Type>* current;
	binaryNode<Type>* trailCurrent;
	binaryNode<Type>* temp;

	if (p == nullptr)
		cout << "The item is not in the list" << endl;
	else if (p->lLink == nullptr && p->rLink == nullptr)
	{
		temp = p;
		p = nullptr;
		delete temp;
	}
	else if (p->lLink == nullptr)
	{
		temp = p;
		p = temp->rLink;
		delete temp;
	}
	else if (p->rLink == nullptr)
	{
		temp = p;
		p = temp->lLink;
		delete temp;
	}
	else
	{
		current = p->lLink;
		trailCurrent = nullptr;
		while (current->rLink != nullptr)
		{
			trailCurrent = current;
			current = current->rLink;
		}
		Type* temp;
		temp = p->info;
		p->info = current->info;
		current->info = temp;
		if (trailCurrent == nullptr)
			p->lLink = current->lLink;
		else
			trailCurrent->rLink = current->lLink;
		delete current;
	}
}

template <class Type>
void binarySearchTree<Type>::deleteNode(const Type& deleteItem, int (*compare) (Type item1, Type item2))
{
	binaryNode<Type>* current;
	binaryNode<Type>* trailCurrent;
	bool found = false;

	if (root == nullptr)
		cout << "Tree is empty" << endl;
	else
	{
		current = root;
		trailCurrent = root;
		while (current != nullptr && !found)
		{
			if ((*compare)(*current->info, deleteItem) == 0)
				found = true;
			else
			{
				trailCurrent = current;
				if ((*compare)(*current->info, deleteItem) > 0)
					current = current->lLink;
				else
					current = current->rLink;
			}
		}
		if (current == nullptr || !found)
			cout << "The item is not in the tree" << endl;
		else
		{
			if (current == root)
				deleteFromTree(root);
			else if ((*compare)(*trailCurrent->info, deleteItem) > 0)
				deleteFromTree(trailCurrent->lLink);
			else
				deleteFromTree(trailCurrent->rLink);
		}
	}
}

template <class Type>
int binarySearchTree<Type>::treeNodeCount() const {
	binaryNode<Type>* current;
	
	current = root;


	if (current == nullptr)
		return 0;

	int nodeCount = 0;
	if (current->lLink && current->rLink)
		nodeCount++;

	nodeCount += (treeNodeCount(current->lLink) +
		treeNodeCount(current->rLink));
	return nodeCount;

}
template <class Type>
int binarySearchTree<Type>::treeLeavesCount() const {
	binaryNode<Type>* current;
	current = root;
	
	if (current == nullptr)
		return 0;
	if (current->lLink == nullptr && current->rLink == nullptr)
		return 1;
	else
		return treeLeavesCount() + treeLeavesCount();
}

#endif


















