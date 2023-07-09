import { Router } from "express";
import UserController from "../controllers/UserController.js";
import authCheck from "../middlewares/Auth.js";

const router = Router();

/**
 * Rota responsável por gerar um token de autenticação
 * @name authToken
 */
router.post("/auth/token", UserController.getAuthToken);

/**
 * Middleware responsável por verificar se o usuário está autenticado
 * @name authCheck
 * @param {object} req Objeto de requisição
 * @param {object} res Objeto de resposta
 * @param {object} next Objeto de próxima função
 */
router.use(authCheck);

/**
 * Rota responsável por procurar um usuário pelo email
 * @name findByEmail
 * @route {GET} /api/v1/findByEmail
 * @authentication Essa rota requer autenticação
 * @bodyparam {string} email Email do usuário
 * @response {json} Retorna um objeto com os dados do usuário caso ele seja encontrado
 * @response {json} Retorna um objeto com a mensagem de erro caso o usuário não seja encontrado
 */
router.get("/findByEmail/", UserController.findByEmail);

/**
 * Rota responsável por procurar um usuário pelo id
 * @name findById
 * @route {GET} /api/v1/findById
 * @authentication Essa rota requer autenticação
 * @param {int} id Id do usuário
 * @response {json} Retorna um objeto com os dados do usuário caso ele seja encontrado
 * @response {json} Retorna um objeto com a mensagem de erro caso o usuário não seja encontrado
 */
router.get("/findById/:id", UserController.findById);



export default router;