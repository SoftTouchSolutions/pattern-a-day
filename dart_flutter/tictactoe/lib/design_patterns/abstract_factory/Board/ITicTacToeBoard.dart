import 'package:tictactoe/design_patterns/abstract_factory/BoardSpace/ITicTacToeBoardSpace.dart';
import 'package:flutter/material.dart';


abstract class ITicTacToeBoard {
  ITicTacToeBoardSpace getBoardSpace();
  ITicTacToeBoardLine buildLines();
  Widget render();
}