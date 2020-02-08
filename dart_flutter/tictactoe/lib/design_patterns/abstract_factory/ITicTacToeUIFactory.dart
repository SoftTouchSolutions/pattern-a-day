import 'package:tictactoe/design_patterns/abstract_factory/Board/ITicTacToeBoard.dart';


abstract class ITicTacToeUIFactory {
  ITicTacToeBoard getBoard(ITicTacToeBoard board);
}