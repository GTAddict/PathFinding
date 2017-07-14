#include "pch.h"
#include "IPathFinder.h"

using namespace std;

namespace Library
{
	deque<NodePtr> IPathFinder::FindPath(NodePtr start, NodePtr end)
	{
		set<NodePtr> closedSet;
		return FindPath(start, end, closedSet);
	}
}