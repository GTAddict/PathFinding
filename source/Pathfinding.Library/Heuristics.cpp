#include "pch.h"
#include "Heuristics.h"

namespace Library
{
	bool Heuristics::GreaterThan::operator()(const std::shared_ptr<Node>& lhs, const std::shared_ptr<Node>& rhs) const
	{
		return lhs->TotalCost() > rhs->TotalCost();
	}

	float Heuristics::ManhattanDistance(std::shared_ptr<Node> current, std::shared_ptr<Node> end)
	{
		return static_cast<float>(abs(end->Location().X() - current->Location().X()) + abs(end->Location().Y() - current->Location().Y()));
	}

	float Heuristics::ConstantOneDistance(std::shared_ptr<Node> current, std::shared_ptr<Node> next)
	{
		UNREFERENCED_PARAMETER(current);
		UNREFERENCED_PARAMETER(next);

		return 1.0f;
	}
}
