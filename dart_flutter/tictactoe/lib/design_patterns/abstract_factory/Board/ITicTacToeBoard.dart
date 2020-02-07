import 'package:tictactoe/design_patterns/abstract_factory/BoardSpace/ITicTacToeBoardSpace.dart';
import 'package:tictactoe/design_patterns/abstract_factory/Board/ITicTacToeBoard.dart';


abstract class ITicTacToeBoard {
  ITicTacToeBoardSpace getBoardSpace();
  Widget render();
}