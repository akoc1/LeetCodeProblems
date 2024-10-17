#include <iostream>
#include <vector>

int maxArea(std::vector<int>& height) {
    int max = 0, right = height.size() - 1, left = 0;

    while (left < right) {
        int area = std::min(height[left], height[right]) * (right - left);
        max = std::max(area, max);

        if (height[left] < height[right]) {
            left += 1;
        } else {
            right -= 1;
        }
    }

    return max;
}

int main(){
    std::vector<int> height = {1,8,6,2,5,4,8,3,7};

    int result = maxArea(height);

    std::cout << "Result: " << result << std::endl;

    return 0;
}
