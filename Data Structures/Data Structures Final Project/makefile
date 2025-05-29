all: card
	g++ -pedantic-errors -g main.cpp card
card: card.h card.cpp
	g++ -pedantic-errors -g -c card.cpp -o card
clean:
	rm card
	rm a.out